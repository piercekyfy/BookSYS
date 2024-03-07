using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BookSYS.Models;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace BookSYS
{
    internal class DBService : IDBContext
    {
        OracleConnection connection;

        public DBService(OracleConnection connection) 
        {
            this.connection = connection;
        }

        #region Books

        /// <summary>
        /// Gets all books with a status of 'A'
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> GetBooks()
        {
            string query = "SELECT * FROM Books WHERE Status = 'A'";

            OracleCommand command = new OracleCommand(query, connection);

            connection.Open();

            OracleDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Book book = new Book(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetDouble(5), dr.GetInt32(6), dr.GetString(7));
                book.Status = dr.GetChar(8);

                yield return book;
            }

            connection.Close();
        }

        /// <summary>
        /// Gets the book with the specified id regardless of its status.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the book does not exist in the database.</exception>
        public Book GetBook(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("Invalid id.");

            string query = "SELECT * FROM Books WHERE BookId = :id";

            OracleCommand command = new OracleCommand(query, connection);
            command.Parameters.Add(":id", id);
            connection.Open();

            OracleDataReader dr = command.ExecuteReader();

            dr.Read();

            if(dr.IsDBNull(0))
            {
                throw new ArgumentException($"Book with a BookId of {id} does not exist.");
            }

            Book book = new Book(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetDouble(5), dr.GetInt32(6), dr.GetString(7));

            connection.Close();

            return book;
        }

        /// <summary>
        /// Gets the id and name of all books with a status of 'A' that 1. Exactly match title, 2. Start with title and 3. Contain title; In that order.
        /// </summary>
        public IEnumerable<IdNamePair> GetBooksByApproximateTitle(string title)
        {
            string query = @"SELECT BookId, Title FROM Books 
                            WHERE (UPPER(Title) LIKE :search OR UPPER(Title) LIKE :search ||'%' OR UPPER(TITLE) LIKE '%'|| :search ||'%') AND Status = 'A'
                            ORDER BY ( 
                            CASE WHEN UPPER(Title) LIKE :search THEN 3 
                            WHEN UPPER(TITLE) LIKE :search ||'%' THEN 2
                            WHEN UPPER(TITLE) LIKE '%'|| :search ||'%' THEN 1 END) DESC";


            OracleCommand command = new OracleCommand(query, connection);
            command.Parameters.Add("search", title.ToUpper());
            
            connection.Open();

            OracleDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                var result = new IdNamePair(dr.GetInt32(0), dr.GetString(1));
                yield return result;
            }

            connection.Close();
        }

        /// <summary>
        /// Inserts a book without an id and updates a book with an id.
        /// </summary>
        /// <param name="book"></param>
        public void Save(Book book)
        {
            if (book.BookId.HasValue)
                Update(book);
            else
                Insert(book);
        }

        public void Insert(Book book)
        {
            string query = @"INSERT INTO Books (Title, Author, Description, Publisher, Price, Quantity, ISBN)
                            VALUES( :title , :author , :description , :publisher , :price , :quantity , :isbn )";

            OracleCommand command = new OracleCommand(query, connection);
            // NOTE: If BindByName isn't true, it expects Parameters to be added in the order they appear in the query regardless of name.
            command.BindByName = true;

            command.Parameters.Add("title", book.Title);
            command.Parameters.Add("author", book.Author);
            command.Parameters.Add("description", book.Description);
            command.Parameters.Add("publisher", book.Publisher);
            command.Parameters.Add("price", book.Price);
            command.Parameters.Add("quantity", book.Quantity);
            command.Parameters.Add("isbn", book.ISBN);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void Update(Book book)
        {
            string query = @"UPDATE Books
                            SET Title = :title, Author = :author, Description = :description, Publisher = :publisher, Price = :price, Quantity = :quantity, ISBN = :isbn
                            WHERE BookId = :id";

            OracleCommand command = new OracleCommand(query, connection);
            command.BindByName = true;

            command.Parameters.Add("title", book.Title);
            command.Parameters.Add("author", book.Author);
            command.Parameters.Add("description", book.Description);
            command.Parameters.Add("publisher", book.Publisher);
            command.Parameters.Add("price", book.Price);
            command.Parameters.Add("quantity", book.Quantity);
            command.Parameters.Add("isbn", book.ISBN);
            command.Parameters.Add("id", book.BookId.Value);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// Removes a book with specified id.
        /// </summary>
        /// <param name="book"></param>
        public void DeleteBook(int id)
        {
            if (id < 0)
                throw new ArgumentNullException("Invalid Id");

            string query = @"UPDATE Books
                            SET Status = 'N'
                            WHERE BookId = :id ";

            OracleCommand command = new OracleCommand(query, connection);
            command.BindByName = true;

            command.Parameters.Add("id", id);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        #endregion

        #region Clients

        public IEnumerable<Client> GetClients()
        {
            string query = "SELECT * FROM Clients WHERE Status = 'O'";

            OracleCommand command = new OracleCommand(query, connection);

            connection.Open();

            OracleDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Client client = new Client(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7));

                yield return client;
            }

            connection.Close();
        }

        public Client GetClient(int id)
        {
            if (id < 0)
                throw new ArgumentException("Invalid Id");

            string query = "SELECT * FROM Clients WHERE ClientId = :id";

            OracleCommand command = new OracleCommand(query, connection);
            command.Parameters.Add(":id", id);
            connection.Open();

            OracleDataReader dr = command.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
            {
                throw new ArgumentException($"Client with a ClientId of {id} does not exist.");
            }

            Client client = new Client(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7));

            connection.Close();

            return client;
        }

        public IEnumerable<IdNamePair> GetClientsByApproximateName(string name)
        {
            string query = @"SELECT ClientId, Name FROM Clients
                            WHERE (UPPER(Name) LIKE :search OR UPPER(Name) LIKE :search ||'%' OR UPPER(Name) LIKE '%'|| :search ||'%') AND Status = 'O'
                            ORDER BY ( 
                            CASE WHEN UPPER(Name) LIKE :search THEN 3 
                            WHEN UPPER(Name) LIKE :search ||'%' THEN 2
                            WHEN UPPER(Name) LIKE '%'|| :search ||'%' THEN 1 END) DESC";


            OracleCommand command = new OracleCommand(query, connection);
            command.Parameters.Add("search", name.ToUpper());

            connection.Open();

            OracleDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                var result = new IdNamePair(dr.GetInt32(0), dr.GetString(1));
                yield return result;
            }

            connection.Close();
        }

        public void Save(Client client)
        {
            if (client.ClientId.HasValue)
                Update(client);
            else
                Insert(client);
        }

        public void Insert(Client client)
        {
            string query = @"INSERT INTO Clients (Name, Street, City, County, Eircode, Email, Phone)
                            VALUES( :name , :street , :city , :county , :eircode , :email , :phone)";

            OracleCommand command = new OracleCommand(query, connection);
            command.BindByName = true;

            command.Parameters.Add("name", client.Name);
            command.Parameters.Add("street", client.Street);
            command.Parameters.Add("city", client.City);
            command.Parameters.Add("county", client.County);
            command.Parameters.Add("eircode", client.Eircode);
            command.Parameters.Add("email", client.Email);
            command.Parameters.Add("phone", client.Phone);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void Update(Client client)
        {
            string query = @"UPDATE Clients
                            SET Name = :name , Street = :street , City = :city , County = :county , Eircode = :eircode , Email = :email , Phone = :phone
                            WHERE ClientId = :id";

            OracleCommand command = new OracleCommand(query, connection);
            command.BindByName = true;

            command.Parameters.Add("name", client.Name);
            command.Parameters.Add("street", client.Street);
            command.Parameters.Add("city", client.City);
            command.Parameters.Add("county", client.County);
            command.Parameters.Add("eircode", client.Eircode);
            command.Parameters.Add("email", client.Email);
            command.Parameters.Add("phone", client.Phone);
            command.Parameters.Add("id", client.ClientId.Value);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void DeleteClient(int id)
        {
            if (id < 0)
                throw new ArgumentNullException("Invalid Id");

            string query = @"UPDATE Clients
                            SET Status = 'C'
                            WHERE ClientId = :id ";

            OracleCommand command = new OracleCommand(query, connection);
            command.BindByName = true;

            command.Parameters.Add("id", id);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        #endregion


        public IEnumerable<Order> GetOrdersByClient(Client client)
        {
            throw new NotImplementedException();
        }


        public void AddBookOrder(BookOrder bookOrder)
        {
            throw new NotImplementedException();
        }

        

        public void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void CancelOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public void DispatchOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookOrder> GetBookOrdersByOrder(Order order)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Order> GetPaidOrders()
        {
            throw new NotImplementedException();
        }

        public int NextOrderId()
        {
            throw new NotImplementedException();
        }

        public void PayOrder(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}

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

        #region Orders

        public IEnumerable<Order> GetOrders()
        {
            string query = "SELECT * FROM Orders";

            OracleCommand command = new OracleCommand(query, connection);

            connection.Open();

            OracleDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Order order = new Order(dr.GetInt32(0), dr.GetInt32(1), dr.GetDateTime(2), dr.GetDouble(3), dr.GetChar(4));

                yield return order;
            }

            connection.Close();
        }

        public IEnumerable<Order> GetPaidOrders()
        {
            string query = "SELECT * FROM Orders WHERE Status = 'P'";

            OracleCommand command = new OracleCommand(query, connection);

            connection.Open();

            OracleDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Order order = new Order(dr.GetInt32(0), dr.GetInt32(1), dr.GetDateTime(2), dr.GetDouble(3), dr.GetChar(4));

                yield return order;
            }

            connection.Close();
        }

        public IEnumerable<Order> GetOrdersByClient(int id)
        {
            if (id < 0)
                throw new ArgumentNullException("Invalid Id");

            string query = "SELECT * FROM Orders WHERE ClientId = :id";

            OracleCommand command = new OracleCommand(query, connection);
            command.BindByName = true;

            command.Parameters.Add("id", id);

            connection.Open();

            OracleDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Order order = new Order(dr.GetInt32(0), dr.GetInt32(1), dr.GetDateTime(2), dr.GetDouble(3), dr.GetString(4)[0]);

                yield return order;
            }

            connection.Close();
        }

        public IEnumerable<BookOrder> GetBookOrdersByOrder(int id)
        {
            if (id < 0)
                throw new ArgumentNullException("Invalid Id");

            string query = "SELECT * FROM BookOrders WHERE OrderId = :id";

            OracleCommand command = new OracleCommand(query, connection);
            command.BindByName = true;

            command.Parameters.Add("id", id);

            connection.Open();

            OracleDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                BookOrder bookOrder = new BookOrder(dr.GetInt32(0), dr.GetInt32(1), dr.GetDouble(2), dr.GetInt32(3));

                yield return bookOrder;
            }

            connection.Close();
        }

        public void Save(Order order)
        {
            if (order.OrderId.HasValue)
                Update(order);
            else
                Insert(order);
        }

        public int Insert(Order order)
        {
            string query = @"INSERT INTO Orders (ClientId, OrderDate, Total)
                            VALUES( :clientId , :orderDate , :total)";

            OracleCommand command = new OracleCommand(query, connection);
            command.BindByName = true;

            command.Parameters.Add("clientId", order.ClientId);
            command.Parameters.Add("orderDate", order.OrderDate);
            command.Parameters.Add("total", order.Total);

            connection.Open();

            command.ExecuteNonQuery();

            OracleCommand idCommand = new OracleCommand("SELECT idSeq_Orders.currval from dual", connection);

            int id = int.Parse(idCommand.ExecuteScalar().ToString());

            connection.Close();

            return id;
        }

        public void Update(Order order)
        {
            string query = @"UPDATE Orders
                            SET ClientId = :clientId , OrderDate = :orderDate , Total = :total , Status = :status
                            WHERE OrderId = :id";

            OracleCommand command = new OracleCommand(query, connection);
            command.BindByName = true;

            command.Parameters.Add("clientId", order.ClientId);
            command.Parameters.Add("orderDate", order.OrderDate);
            command.Parameters.Add("total", order.Total);
            command.Parameters.Add("status", order.Status);
            command.Parameters.Add("id", order.OrderId.Value);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void Insert(BookOrder bookOrder)
        {
            string query = @"INSERT INTO BookOrders (OrderId, BookId, SalePrice, Quantity)
                            VALUES( :orderId , :bookId , :salePrice , :quantity )";

            OracleCommand command = new OracleCommand(query, connection);
            command.BindByName = true;

            command.Parameters.Add("orderId", bookOrder.OrderId);
            command.Parameters.Add("bookId", bookOrder.BookId);
            command.Parameters.Add("salePrice", bookOrder.SalePrice);
            command.Parameters.Add("quantity", bookOrder.Quantity);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public int Insert(Order order, List<BookOrder> bookOrders)
        {
            int id = Insert(order);

            foreach(BookOrder bookOrder in bookOrders)
            {
                bookOrder.OrderId = id;
                Insert(bookOrder);
            }

            return id;
        }

        public void DeleteOrder(int id)
        {
            if (id < 0)
                throw new ArgumentNullException("Invalid Id");

            string query = @"UPDATE Orders
                            SET Status = 'C'
                            WHERE OrderId = :orderId ";

            OracleCommand command = new OracleCommand(query, connection);
            command.BindByName = true;

            command.Parameters.Add("orderId", id);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        #endregion

    }
}

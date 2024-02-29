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

        public IEnumerable<Book> GetBooks()
        {
            throw new NotImplementedException();
        }

        public Book GetBook(int id)
        {
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

        public IEnumerable<IdNamePair> GetBooksByApproximateTitle(string title)
        {
            string query = @"SELECT BookId, Title FROM Books 
                            WHERE UPPER(Title) LIKE :search OR UPPER(Title) LIKE :search ||'%' OR UPPER(TITLE) LIKE '%'|| :search ||'%' 
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

        public void AddBook(Book book)
        {
            Console.WriteLine("Attempted to add a book with an Id of: " + book.BookId);
        }

        public void UpdateBook(Book book)
        {
            string query = @"UPDATE Books
                            SET Title = :title, Author = :author, Description = :description, Publisher = :publisher, Price = :price, Quantity = :quantity, ISBN = :isbn
                            WHERE BookId = :id";
            
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
            command.Parameters.Add("id",book.BookId );

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

        }

        public void RemoveBook(int bookId)
        {
            throw new NotImplementedException();
        }

        #endregion

        public void AddBookOrder(BookOrder bookOrder)
        {
            throw new NotImplementedException();
        }

        public void AddClient(Client client)
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

        

        public IEnumerable<Client> GetClients()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetClientsByApproximateName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrdersByClient(Client client)
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

        

        public void RemoveClient(int clientId)
        {
            throw new NotImplementedException();
        }

        

        public void UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}

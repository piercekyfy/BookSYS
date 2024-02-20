using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

        public int NextBookId()
        {
            string query = "SELECT MAX(BookId) FROM Books";

            OracleCommand command = new OracleCommand(query, connection);

            connection.Open();

            OracleDataReader dr = command.ExecuteReader();

            dr.Read();

            int nextId = dr.IsDBNull(0) ? 1 : (dr.GetInt32(0) + 1);

            connection.Close();

            return nextId;
        }

        public IEnumerable<Book> GetBooks()
        {
            throw new NotImplementedException();
        }

        public Book GetBook(int id)
        {
            string query = "SELECT * FROM Books WHERE Id = :ID";

            OracleCommand command = new OracleCommand(query, connection);
            command.Parameters.Add("ID", id);
            connection.Open();

            OracleDataReader dr = command.ExecuteReader();

            dr.Read();

            return new Book(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetDouble(5), dr.GetInt32(6), dr.GetString(7));
        }

        public IEnumerable<IdNamePair> GetBooksByApproximateTitle(string title)
        {
            string query = @"SELECT BookId, Title FROM Books 
                            WHERE UPPER(Title) LIKE ':QUERY' OR UPPER(Title) LIKE ':QUERY%' OR UPPER(TITLE) LIKE '%:QUERY%' 
                            ORDER BY ( 
                            CASE WHEN Title LIKE ':QUERY' THEN 3 
                            WHEN TITLE LIKE ':QUERY%' THEN 2
                            WHEN TITLE LIKE '%:QUERY%' THEN 1 END) ASC";

            OracleCommand command = new OracleCommand(query, connection);
            command.Parameters.Add("QUERY", title.ToUpper());
            connection.Open();

            OracleDataReader dr = command.ExecuteReader();

            while(dr.Read())
            {   
                var result = new IdNamePair(dr.GetInt32(0), dr.GetString(1));
                Debug.WriteLine(result.Id);
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
            Console.WriteLine("Attempted to update a book with an Id of: " + book.BookId);
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

        
        public int NextClientId()
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

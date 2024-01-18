using System;
using System.Collections.Generic;
using System.Linq;
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

        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

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

        public IEnumerable<Book> GetBooks()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooksByApproximateTitle(string title)
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

        public int NextBookId()
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

        public void RemoveBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public void RemoveClient(int clientId)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}

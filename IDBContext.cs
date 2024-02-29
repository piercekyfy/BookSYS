using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSYS
{
    public interface IDBContext
    {
        #region Books
        /// <summary>
        /// Gets all available books (Books with a Status of 'A')
        /// </summary>
        IEnumerable<Book> GetBooks();

        Book GetBook(int id);

        /// <summary>
        /// Gets all available books (Books with a Status of 'A') whose title's contain the specified string
        /// </summary>
        IEnumerable<IdNamePair> GetBooksByApproximateTitle(string title);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void RemoveBook(int bookId);
        #endregion

        #region Clients
        IEnumerable<Client> GetClients();
        IEnumerable<Client> GetClientsByApproximateName(string name);
        void AddClient(Client client);
        void UpdateClient(Client client);
        void RemoveClient(int clientId);
        #endregion

        #region Orders

        IEnumerable<Order> GetOrdersByClient(Client client);
        IEnumerable<Order> GetPaidOrders();
        void AddOrder(Order order);
        void DispatchOrder(int orderId);
        void CancelOrder(int orderId);
        void PayOrder(int orderId);
        int NextOrderId();

        #endregion

        #region BookOrders

        IEnumerable<BookOrder> GetBookOrdersByOrder(Order order);
        void AddBookOrder(BookOrder bookOrder);

        #endregion
    }
}

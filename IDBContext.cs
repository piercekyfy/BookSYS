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
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
        IEnumerable<IdNamePair> GetBooksByApproximateTitle(string title);
        void Save(Book book);
        void DeleteBook(int id);
        #endregion

        #region Clients
        IEnumerable<Client> GetClients();
        Client GetClient(int id);
        IEnumerable<IdNamePair> GetClientsByApproximateName(string name);
        void Save(Client client);
        void DeleteClient(int id);
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

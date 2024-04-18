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
        IEnumerable<Order> GetPaidOrders();
        IEnumerable<Order> GetOrdersByClient(int id);
        IEnumerable<BookOrder> GetBookOrdersByOrder(int id);
        void Save(Order order);
        int Insert(Order order);
        void Insert(BookOrder bookOrder);
        int Insert(Order order, List<BookOrder> bookOrders);
        void DeleteOrder(int id);
        #endregion
    }
}

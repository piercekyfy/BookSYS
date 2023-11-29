﻿using BookSYS.Models;
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
        /// <summary>
        /// Gets all available books (Books with a Status of 'A') whose title's contain the specified string
        /// </summary>
        IEnumerable<Book> GetBooksByApproximateTitle(string title);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void RemoveBook(int bookId);
        int NextBookId();
        #endregion

        #region Clients
        IEnumerable<Client> GetClients();
        IEnumerable<Client> GetClientsByApproximateName(string name);
        void AddClient(Client client);
        void UpdateClient(Client client);
        void RemoveClient(int clientId);
        int NextClientId();
        #endregion

        #region Orders

        IEnumerable<Order> GetOrdersByClient(Client client);
        void AddOrder(Order order);

        #endregion

        #region BookOrders

        IEnumerable<BookOrder> GetBookOrders(Order order);
        void AddBookOrder(BookOrder bookOrder);

        #endregion
    }
}

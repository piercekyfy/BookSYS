using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace BookSYS.Forms
{
    /// <summary>
    /// This class simulates a database. It does not perform any validation, including checking for existing Ids.
    /// </summary>
    public class DummyDBSingleton
    {
        private static DummyDBSingleton _instance;
        public static DummyDBSingleton Instance
        {
            get
            {
                _instance = _instance ?? new DummyDBSingleton();
                return _instance;
            }
        }

        private DummyDBSingleton()
        {
            this.Debug_PopulateBooks();
            this.Debug_PopulateClients();
            this.Debug_PopulateOrders();
            this.Debug_PopulateBookOrders();
        }

        List<Book> books = new List<Book>();
        List<Client> clients = new List<Client>();
        List<Order> orders = new List<Order>();
        List<BookOrder> bookOrders = new List<BookOrder>();

        #region Books
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            foreach (var storedBook in books)
            {
                if(storedBook.BookId == book.BookId)
                {
                    storedBook.Title = book.Title;
                    storedBook.Author = book.Author;
                    storedBook.Description = book.Description;
                    storedBook.Publisher = book.Publisher;
                    storedBook.Price = book.Price;
                    storedBook.Quantity = book.Quantity;
                    storedBook.ISBN = book.ISBN;

                    return;
                }
            }

            throw new Exception("Attempted to update non-existent book.");
        }

        public void RemoveBook(int bookId)
        {
            foreach (var storedBook in books)
            {
                if(storedBook.BookId == bookId)
                {
                    storedBook.Status = 'N';
                    //books.Remove(storedBook);
                    return;
                }
            }
        }

        public IEnumerable<Book> GetBooks()
        {
            foreach (var book in books)
            {
                if(book.Status == 'A')
                    yield return book;
            }
        }

        public IEnumerable<Book> GetBooksByApproximateTitle(string title)
        {
            if (title == null)
            {
                yield break;
            }

            foreach(var book in GetBooks())
            {
                if (book.Title.ToUpper().Contains(title.ToUpper()))
                {
                    yield return book;
                }
            }
        }

        public int NextBookId()
        {
            int largest = -1;
            foreach(var book in books)
            {
                if(book.BookId > largest)
                {
                    largest = book.BookId.Value;
                }
            }

            if(largest + 1 > 9999)
            {
                throw new Exception("Couldn't find a largest valid Id.");
            }

            return largest + 1;
        }
        #endregion

        #region Clients
        public void AddClient(Client client)
        {
            clients.Add(client);
        }

        public void UpdateClient(Client client)
        {
            foreach (var storedClient in clients)
            {
                if (storedClient.ClientId == client.ClientId)
                {
                    storedClient.Name = client.Name;
                    storedClient.Street = client.Street;
                    storedClient.City = client.City;
                    storedClient.County = client.County;
                    storedClient.Eircode = client.Eircode;
                    storedClient.Email = client.Email;
                    storedClient.Phone = client.Phone;

                    return;
                }
            }

            throw new Exception("Attempted to update non-existent client.");
        }

        public void RemoveClient(int clientId)
        {
            foreach (var storedClient in clients)
            {
                if (storedClient.ClientId == clientId)
                {
                    storedClient.Status = 'C';
                    //clients.Remove(storedClient);
                    return;
                }
            }
        }

        public IEnumerable<Client> GetClients()
        {
            foreach (var client in clients)
            {
                if (client.Status == 'O')
                    yield return client;
            }
        }

        public IEnumerable<Client> GetClientsByApproximateName(string name)
        {
            if (name == null)
            {
                yield break;
            }

            foreach (var client in GetClients())
            {
                if (client.Name.ToUpper().Contains(name.ToUpper()))
                {
                    yield return client;
                }

            }
        }

        public int NextClientId()
        {
            int largest = -1;
            foreach (var client in clients)
            {
                if (client.ClientId.Value > largest)
                {
                    largest = client.ClientId.Value;
                }
            }

            if (largest + 1 > 9999)
            {
                throw new Exception("Couldn't find a largest valid Id.");
            }

            return largest + 1;
        }

        #endregion

        #region Orders

        public Order GetOrderById(int id)
        {
            foreach(var order in orders)
            {
                if(order.OrderId == id)
                {
                    return order;
                }
            }
            return null;
        }

        public IEnumerable<Order> GetOrdersByClient(Client client)
        {
            foreach(Order order in orders)
            {
                if(order.Client == client && order.Status != 'C')
                {
                    yield return order;
                }
            }
        }

        public IEnumerable<Order> GetPaidOrders()
        {
            foreach (Order order in orders)
            {
                if (order.Status == 'P')
                {
                    yield return order;
                }
            }
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void DispatchOrder(int orderId)
        {
            Order order = GetOrderById(orderId);

            if (order == null)
                throw new ArgumentException("Invalid OrderId");

            order.Status = 'D';
        }

        public void CancelOrder(int orderId)
        {
            Order order = GetOrderById(orderId);

            if (order == null)
                throw new ArgumentException("Invalid OrderId");

            order.Status = 'C';
        }

        public void PayOrder(int orderId)
        {
            Order order = GetOrderById(orderId);

            if (order == null)
                throw new ArgumentException("Invalid OrderId");

            order.Status = 'P';
        }

        public int NextOrderId()
        {
            int largest = -1;
            foreach (var order in orders)
            {
                if (order.OrderId > largest)
                {
                    largest = order.OrderId;
                }
            }

            if (largest + 1 > 9999)
            {
                throw new Exception("Couldn't find a largest valid Id.");
            }

            return largest + 1;
        }

        #endregion

        #region BookOrders

        public IEnumerable<BookOrder> GetBookOrdersByOrder(Order order)
        {
            foreach (BookOrder bookOrder in bookOrders)
            {
                if (bookOrder.Order == order)
                {
                    yield return bookOrder;
                }
            }
        }

        public void AddBookOrder(BookOrder bookOrder)
        {
            bookOrders.Add(bookOrder);
        }

        #endregion

        public void Debug_PopulateBooks()
        {
            AddBook(new Book(0001, "Frankenstein", "Mary Shelly", "A monster! The scientist! Who??", "Lackington, Hughes, Harding, Mavor & Jones", 15.45, 80, "9781861972712"));
            AddBook(new Book(0002, "Mice and Men", "John Steinbeck", "He shoots him! Gasp.", "Penguin", 10, 200, "9788431634506"));
            AddBook(new Book(0003, "Cherub", "Robert Muchamore", "Spies!", "Simon & Schuster", 25, 45, "9780340881538"));
        }

        public void Debug_PopulateClients()
        {
            AddClient(new Client(0001, "Lil' Bookstore", "43 Moyderwell", "Tralee", "Kerry", "V92PX56", "lilbookstore@gmail.com", "894054052"));
            AddClient(new Client(0002, "Big Book(s)store!", "32 Castle Street Upper", "Tralee", "Kerry", "V92RX64", "internal@bigbooks.com", "892055452"));
            AddClient(new Client(0003, "Crazy Books", "40 Pembroke Square", "Tralee", "Kerry", "V92EHH3", "crazyybooks@gmail.com", "872088122"));
        }

        public void Debug_PopulateOrders()
        {
            //// Unpaid Orders
            //AddOrder(new Order(0001, clients[0], DateTime.UtcNow, books[0].Price * 45, 'U'));
            //AddOrder(new Order(0002, clients[1], DateTime.UtcNow, books[1].Price * 25, 'U'));
            //AddOrder(new Order(0003, clients[2], DateTime.UtcNow, books[2].Price * 30, 'U'));

            //// Paid Orders
            //AddOrder(new Order(0004, clients[0], DateTime.UtcNow, books[0].Price * 4000, 'P'));
            //AddOrder(new Order(0005, clients[1], DateTime.UtcNow, books[1].Price * 250, 'P'));
            //AddOrder(new Order(0006, clients[2], DateTime.UtcNow, books[2].Price * 2, 'P'));
        }

        public void Debug_PopulateBookOrders()
        {
            //AddBookOrder(new BookOrder(orders[0], books[0], books[0].Price, 45));
            //AddBookOrder(new BookOrder(orders[1], books[1], books[1].Price, 25));
            //AddBookOrder(new BookOrder(orders[2], books[2], books[2].Price, 30));

            //AddBookOrder(new BookOrder(orders[3], books[0], books[0].Price, 4000));
            //AddBookOrder(new BookOrder(orders[4], books[1], books[1].Price, 250));
            //AddBookOrder(new BookOrder(orders[5], books[2], books[2].Price, 2));
        }

        public Book GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Book book)
        {
            throw new NotImplementedException();
        }

        public void Save(Client client)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(Client client)
        {
            throw new NotImplementedException();
        }
    }
}

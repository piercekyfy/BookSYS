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
    }
}

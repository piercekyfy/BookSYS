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
        IEnumerable<Book> GetBooks();
        IEnumerable<Book> GetBooksByAproxTitle(string title);
        void AddBook(Book book);
        void UpdateBook(Book book);
        int NextBookId();
    }
}

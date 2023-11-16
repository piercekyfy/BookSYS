using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookSYS.Forms
{
    public class DummyDbSingleton : IDBContext
    {
        private static DummyDbSingleton _instance;
        public static DummyDbSingleton Instance
        {
            get
            {
                _instance = _instance ?? new DummyDbSingleton();
                return _instance;
            }
        }

        private DummyDbSingleton()
        {
            this.Debug_PopulateBooks();
        }

        List<Book> books = new List<Book>();

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
                    storedBook.PageCount = book.PageCount;
                    storedBook.Price = book.Price;
                    storedBook.Quantity = book.Quantity;
                    storedBook.ISBN = book.ISBN;

                    return;
                }
            }

            throw new Exception("Attempted to update non-existent book");
        }

        public void RemoveBook(int bookId)
        {
            foreach (var storedBook in books)
            {
                if(storedBook.BookId == bookId)
                {
                    books.Remove(storedBook);
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
                    largest = book.BookId;
                }
            }

            if(largest + 1 > 9999)
            {
                throw new Exception("Couldn't find a largest valid Id");
            }

            return largest + 1;
        }

        public void Debug_PopulateBooks()
        {
            AddBook(new Book(0001, "Frankenstein", "Mary Shelly", "A monster! The scientist! Who??", 320, 15.45f, 80, "9780520201798"));
            AddBook(new Book(0002, "Mice and Men", "That Guy", "He shoots him! Gasp.", 200, 10f, 200, "9780230201798"));
            AddBook(new Book(0003, "Cherub", "Robert Something", "Spies!", 250, 25f, 45, "8180520201798"));
        }
    }
}

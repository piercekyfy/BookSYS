using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookSYS.Forms.Books
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
                if(storedBook.Id == book.Id)
                {
                    storedBook.Title = book.Title;
                    storedBook.Author = book.Author;
                    storedBook.Description = book.Description;
                    storedBook.PageCount = book.PageCount;
                    storedBook.Price = book.Price;
                    storedBook.Quantity = book.Quantity;
                    storedBook.Available = book.Available;

                    return;
                }
            }

            throw new Exception("Attempted to update non-existant book");
        }

        public IEnumerable<Book> GetBooks()
        {
            foreach (var book in books)
            {
                yield return book;
            }
        }

        public IEnumerable<Book> GetBooksByAproxTitle(string title)
        {
            foreach(var book in books)
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
                if(book.Id > largest)
                {
                    largest = book.Id;
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
            AddBook(new Book(0001, "Frankenstein", "Mary Shelly", "A monster! The scientist! Who??", 320, 15.45f, 80, true));
            AddBook(new Book(0002, "Mice and Men", "That Guy", "He shoots him! Gasp.", 200, 10f, 200, true));
            AddBook(new Book(0003, "Cherub", "Robert Something", "Spies!", 250, 25f, 45, true));
        }
    }
}

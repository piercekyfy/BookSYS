using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSYS.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string ISBN { get; set; }
        public char Status { get; set; } = 'A';

        public Book()
        {

        }

        public Book(int id, string title, string author, string description, int pageCount, double price, int quantity, string ISBN)
        {
            BookId = id;
            Title = title;
            Author = author;
            Description = description;
            PageCount = pageCount;
            Price = price;
            Quantity = quantity;
            this.ISBN = ISBN;
            Status = 'A';
        }

        public static bool VerifyBook(Book book, out string errorMessage)
        {
            errorMessage = null;

            // Verification

            #region BookId
            if(book.BookId < 0)
            {
                errorMessage = "Id cannot be less than zero.";
                return false;
            }
            if (book.BookId > 9999)
            {
                errorMessage = "Id cannot be larger than 9999.";
                return false;
            }
            #endregion
            #region Title
            if (String.IsNullOrEmpty(book.Title))
            {
                errorMessage = "Title is a required field.";
                return false;
            }
            if (book.Title.Length > 48)
            {
                errorMessage = "Title has a maximum length of 48 characters.";
                return false;
            }
            #endregion
            #region Author
            if(String.IsNullOrEmpty(book.Author))
            {
                errorMessage = "Author is a required field.";
                return false;
            }
            if(book.Author.Length > 24)
            {
                errorMessage = "Author has a maximum length of 24 characters.";
                return false;
            }
            if (!Regex.IsMatch(book.Author, "^[a-zA-Z ]+$"))
            {
                errorMessage = "Author must only contain non-numeric, non-special (excluding spaces) characters.";
                return false;
            }
            #endregion
            #region PageCount
            if (book.PageCount <= 0)
            {
                errorMessage = "Page Count cannot be less than or equal to zero.";
                return false;
            }
            #endregion
            #region Price
            if(book.Price <= 0)
            {
                errorMessage = "Price cannot be less than or equal to zero.";
                return false;
            }
            #endregion
            #region Quantity
            if(book.Quantity < 0)
            {
                errorMessage = "Quantity cannot be less than zero.";
                return false;
            }
            #endregion
            #region ISBN
            if(String.IsNullOrEmpty(book.ISBN))
            {
                errorMessage = "ISBN is a required field.";
                return false;
            }
            if(book.ISBN.Length < 7)
            {
                errorMessage = "ISBN must be a 7 digit number.";
                return false;
            }
            foreach (char character in book.ISBN)
            {
                if (!char.IsDigit(character))
                {
                    errorMessage = "ISBN must be a 7 digit number.";
                    return false;
                }
            }
            #endregion
            #region Status
            if(book.Status != 'A' && book.Status != 'N')
            {
                errorMessage = "Book Status must be 'A' or 'N'";
                return false;
            }
            #endregion

            errorMessage = null;
            return true;
        }

        public override string ToString()
        {
            return this.BookId.ToString() + " (" + this.Title.ToString() + ")";
        }
    }
}

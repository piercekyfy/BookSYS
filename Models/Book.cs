using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookSYS.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Available { get; set; }

        public Book()
        {

        }

        public Book(int id, string title, string author, string description, int pageCount, double price, int quantity, bool available)
        {
            Id = id;
            Title = title;
            Author = author;
            Description = description;
            PageCount = pageCount;
            Price = price;
            Quantity = quantity;
            Available = available;
        }

        public static bool VerifyBook(Book book, out string errorMessage)
        {
            errorMessage = null;

            // Verification

            #region BookId
            if(book.Id < 0)
            {
                errorMessage = "Id cannot be less than zero.";
                return false;
            }
            if (book.Id > 9999)
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

            errorMessage = null;
            return true;
        }

        public override string ToString()
        {
            return this.Id.ToString() + " (" + this.Title.ToString() + ")";
        }
    }
}

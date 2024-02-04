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
        public string Publisher { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string ISBN { get; set; }
        public char Status { get; set; } = 'A';

        public Book()
        {

        }

        public Book(int id, string title, string author, string description, string publisher, double price, int quantity, string ISBN)
        {
            BookId = id;
            Title = title;
            Author = author;
            Description = description;
            Publisher = publisher;
            Price = price;
            Quantity = quantity;
            this.ISBN = ISBN;
            Status = 'A';
        }

        public static bool Validate(Book book, out string invalidProperty, out string error)
        {

            #region BookId
            invalidProperty = nameof(BookId);
            if (book.BookId < 0)
            {
                error = "Id cannot be less than zero.";
                return false;
            }
            if (book.BookId > 9999)
            {
                error = "Id cannot be larger than 9999.";
                return false;
            }
            #endregion

            // This error should always be displayed before anything else.
            #region Null Checks 

            if (String.IsNullOrEmpty(book.Title))
            {
                invalidProperty = nameof(Title);
                error = "Title is a required field.";
                return false;
            }
            if (String.IsNullOrEmpty(book.Author))
            {
                invalidProperty = nameof(Author);
                error = "Author is a required field.";
                return false;
            }
            if (String.IsNullOrEmpty(book.Publisher))
            {
                invalidProperty = nameof(Publisher);
                error = "Publisher is a required field";
                return false;
            }
            if (String.IsNullOrEmpty(book.ISBN))
            {
                invalidProperty = nameof(ISBN);
                error = "ISBN is a required field.";
                return false;
            }

            #endregion

            #region Title
            invalidProperty = nameof(Title);
            
            if (book.Title.Length > 48)
            {
                error = "Title has a maximum length of 48 characters.";
                return false;
            }
            #endregion

            #region Author
            invalidProperty = nameof(Author);
            
            if (book.Author.Length > 24)
            {
                error = "Author has a maximum length of 24 characters.";
                return false;
            }
            if (!Regex.IsMatch(book.Author, "^[a-zA-Z ]+$"))
            {
                error = "Author must only contain non-numeric, non-special (excluding spaces) characters.";
                return false;
            }
            #endregion

            #region Publisher
            invalidProperty = nameof(Publisher);
            
            if (book.Publisher.Length > 48)
            {
                error = "Publisher name cannot exceed 48 characters.";
                return false;
            }
            #endregion

            #region Price
            invalidProperty = nameof(Price);

            if (book.Price <= 0)
            {
                error = "Price cannot be less than or equal to zero.";
                return false;
            }
            #endregion

            #region Quantity
            invalidProperty = nameof(Quantity);

            if (book.Quantity < 0)
            {
                error = "Quantity cannot be less than zero.";
                return false;
            }
            #endregion

            #region ISBN
            invalidProperty = nameof(ISBN);
            
            if (book.ISBN.Length != 13)
            {
                error = "ISBN must be a 13 digit number.";
                return false;
            }

            int total = 0;
            int lastNum = 0;

            for (int i = 0; i < book.ISBN.Length; i++)
            {
                if (int.TryParse(book.ISBN[i].ToString(), out int num))
                {
                    lastNum = num;
                    if (i + 1 == book.ISBN.Length)
                        break;

                    int mul = (i + 1) % 2 == 0 ? 3 : 1;
                    total += (num * mul);

                }
                else
                {
                    error = "ISBN must be a 13 digit number.";
                    return false;
                }
            }

            int check = total % 10;
            if (check != 0)
                check = 10 - check;

            if (check != lastNum)
            {
                error = "Invalid ISBN code";
                return false;
            }
            #endregion

            #region Status
            invalidProperty = nameof(Status);

            if (book.Status != 'A' && book.Status != 'N')
            {
                error = "Book Status must be 'A' or 'N'";
                return false;
            }
            #endregion
            
            // No Validation Errors
            invalidProperty = null;
            error = null;
            return true;
        }

        public override string ToString()
        {
            return this.BookId.ToString() + " (" + this.Title.ToString() + ")";
        }
    }
}

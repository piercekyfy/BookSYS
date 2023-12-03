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

        public static bool VerifyBook(Book book, out string errorMessage)
        {
            errorMessage = null;

            // Verification

            #region BookId
            if (book.BookId < 0)
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
            if (String.IsNullOrEmpty(book.Author))
            {
                errorMessage = "Author is a required field.";
                return false;
            }
            if (book.Author.Length > 24)
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
            #region Publisher
            if (String.IsNullOrEmpty(book.Publisher))
            {
                errorMessage = "Publisher is a required field";
                return false;
            }
            if (book.Publisher.Length > 48)
            {
                errorMessage = "Publisher name cannot exceed 48 characters.";
                return false;
            }
            #endregion
            #region Price
            if (book.Price <= 0)
            {
                errorMessage = "Price cannot be less than or equal to zero.";
                return false;
            }
            #endregion
            #region Quantity
            if (book.Quantity < 0)
            {
                errorMessage = "Quantity cannot be less than zero.";
                return false;
            }
            #endregion
            #region ISBN
            if (String.IsNullOrEmpty(book.ISBN))
            {
                errorMessage = "ISBN is a required field.";
                return false;
            }
            if (book.ISBN.Length != 13)
            {
                errorMessage = "ISBN must be a 13 digit number.";
                return false;
            }

            int total = 0;
            int lastNum = 0;

            for (int i = 0; i < book.ISBN.Length; i++)
            {
                if(int.TryParse(book.ISBN[i].ToString(), out int num))
                {
                    lastNum = num;
                    if (i + 1 == book.ISBN.Length)
                        break;

                    int mul = (i + 1) % 2 == 0 ? 3 : 1;
                    Console.WriteLine(num.ToString() + " * " + mul.ToString());
                    total += (num * mul);

                } else
                {
                    errorMessage = "ISBN must be a 10 or 13 digit number.";
                    return false;
                }
            }

            int check = total % 10;
            if (check != 0)
                check = 10 - check;

            if(check != lastNum)
            {
                errorMessage = "Invalid ISBN code";
                return false;
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

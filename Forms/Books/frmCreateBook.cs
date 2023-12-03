using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSYS.Forms.Books
{
    public partial class frmCreateBook : Form
    {
        IDBContext db;

        public frmCreateBook()
        {
            InitializeComponent();

            db = DummyDbSingleton.Instance;
        }

        public bool ProcessInput(out Book newBook, out string errorMessage)
        {
            newBook = null;
            errorMessage = null;

            #region Check if fields are empty.

            if (!Utils.ValidateFilled(new List<TextBox> { txtTitle, txtAuthor, txtPublisher, txtPrice, txtQuantity, txtISBN }, out TextBox firstEmpty))
            {
                firstEmpty.Focus();
                errorMessage = "Field cannot be empty.";
                return false;
            }

            #endregion

            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string description = txtDescription.Text;
            string publisher = txtPublisher.Text;
            string price = txtPrice.Text;
            string quantity = txtQuantity.Text;
            string ISBN = txtISBN.Text;

            Book book = new Book();

            book.BookId = db.NextBookId();
            book.Title = title;
            book.Author = author;
            book.Description = description;
            book.Publisher = publisher;
            book.ISBN = ISBN;

            double priceNum;
            int quantityNum;
           
            if(!double.TryParse(price, out priceNum))
            {
                txtPrice.Focus();
                errorMessage = "Price must be a decimal number.";
                return false;
            }
            if(!int.TryParse(quantity, out quantityNum))
            {
                txtQuantity.Focus();
                errorMessage = "Quantity must be a whole number.";
                return false;
            }
            book.Price = priceNum;
            book.Quantity = quantityNum;

            // No Errors were encountered in the view inputs
            errorMessage = null;
            newBook = book;

            return Book.VerifyBook(book, out errorMessage);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Book newBook;
            if (!ProcessInput(out newBook, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.AddBook(newBook);
            MessageBox.Show("The book: " + newBook.ToString() + " has been added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtDescription.Clear();
            txtPublisher.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtISBN.Clear();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

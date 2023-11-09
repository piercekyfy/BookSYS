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

            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string description = txtDescription.Text;
            string pageCount = txtPageCount.Text;
            string price = txtPrice.Text;
            string quantity = txtQuantity.Text;

            #region Check if fields are empty.
            
            if (!Utils.ValidateFilled(new List<TextBox> { txtTitle, txtAuthor, txtPageCount, txtPrice, txtQuantity }, out TextBox firstEmpty))
            {
                firstEmpty.Focus();
                errorMessage = "Field cannot be empty.";
                return false;
            }

            #endregion

            Book book = new Book();

            book.Id = db.NextBookId();
            book.Title = title;
            book.Author = author;
            book.Description = description;
            book.Available = true;

            if (db.GetBooks().Where(x => x.Id == book.Id).FirstOrDefault() != null)
            {
                errorMessage = "Specified Id already exists, choose another or delete the existing entry.";
                return false;
            }

            int pageCountNum;
            float priceNum;
            int quantityNum;
            
            if(!int.TryParse(pageCount, out pageCountNum))
            {
                txtPageCount.Focus();
                errorMessage = "Page Count must be a whole number.";
                return false;
            }
            if(!float.TryParse(price, out priceNum))
            {
                txtPrice.Focus();
                errorMessage = "Price must be a decimal number.";
                return false;
            }
            if(!int.TryParse(quantity, out quantityNum))
            {
                txtQuantity.Focus();
                errorMessage = "Quantity must be a whole number.";
            }

            book.PageCount = pageCountNum;
            book.Price = priceNum;
            book.Quantity = quantityNum;

            errorMessage = null;
            newBook = book;

            return Book.VerifyBook(book, out errorMessage);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Book newBook = null;

            if (!ProcessInput(out newBook, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.AddBook(newBook);
            MessageBox.Show("The book: " + newBook.ToString() + " has been added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTitle.Clear();
            txtAuthor.Clear();
            txtDescription.Clear();
            txtPageCount.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }
    }
}

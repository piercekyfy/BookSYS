using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSYS.Forms.Books
{
    public partial class frmUpdateBook : Form
    {
        IDBContext db;
        Book selected = null;

        public frmUpdateBook()
        {
            InitializeComponent();

            db = DummyDbSingleton.Instance;

            IEnumerable<Book> books = db.GetBooks();

            if(books.Count() == 0)
            {
                MessageBox.Show("No Books exist in file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void UpdateIdSelection(string title)
        {
            cboId.Items.Clear();

            List<Book> books = db.GetBooksByApproximateTitle(title).ToList();

            if (books.Count() == 0)
                return;

            foreach(Book book in books)
            {
                cboId.Items.Add(book);
            }
        }

        public void UpdateSelected(Book selected)
        {
            if(selected == null)
            {
                this.selected = null;
                grpBook.Hide();
                return;
            }

            this.selected = selected;

            grpBook.Text = "Update " + selected.ToString();

            txtTitle.Text = selected.Title;
            txtAuthor.Text = selected.Author;
            txtDescription.Text = selected.Description;
            txtPublisher.Text = selected.Publisher;
            txtPrice.Text = selected.Price.ToString();
            txtQuantity.Text = selected.Quantity.ToString();
            txtISBN.Text = selected.ISBN.ToString();

            grpBook.Show();
        }

        public void Update(Book book)
        {
            if (book == null)
                return;

            Book newBook = null;

            if (!ProcessInput(out newBook, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.UpdateBook(newBook);
            MessageBox.Show("The book: " + newBook.ToString() + " has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateSelected(null);
            UpdateIdSelection(txtTitleSearch.Text);
        }

        public bool ProcessInput(out Book newBook, out string errorMessage)
        {
            newBook = null;
            errorMessage = null;

            #region Check if required fields are empty.

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

            book.BookId = selected.BookId;
            book.Title = title;
            book.Author = author;
            book.Description = description;
            book.Publisher = publisher;
            book.ISBN = ISBN;

            float priceNum;
            int quantityNum;

            if (!float.TryParse(price, out priceNum))
            {
                txtPrice.Focus();
                errorMessage = "Price must be a decimal number.";
                return false;
            }
            if (!int.TryParse(quantity, out quantityNum))
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

            // Verify the model
            return Book.VerifyBook(book, out errorMessage);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Update(selected);
        }

        private void txtTitleSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitleSearch.Text))
                return;

            UpdateIdSelection(txtTitleSearch.Text);
        }

        private void cboId_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboId.SelectedIndex == -1)
            {
                UpdateSelected(null);
            } else
            {
                UpdateSelected((Book)cboId.SelectedItem);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

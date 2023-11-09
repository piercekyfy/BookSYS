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

            List<Book> books = db.GetBooksByAproxTitle(title).ToList();

            if (books.Count() == 0)
                return;

            foreach(Book book in db.GetBooksByAproxTitle(title))
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
            txtPageCount.Text = selected.PageCount.ToString();
            txtPrice.Text = selected.Price.ToString();
            txtQuantity.Text = selected.Quantity.ToString();
            ckbAvailable.Checked = selected.Available;

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
            bool available = ckbAvailable.Checked;

            #region Check if fields are empty.

            if (!Utils.ValidateFilled(new List<TextBox> { txtTitle, txtAuthor, txtPageCount, txtPrice, txtQuantity }, out TextBox firstEmpty))
            {
                firstEmpty.Focus();
                errorMessage = "Field cannot be empty.";
                return false;
            }

            #endregion

            Book book = new Book();

            book.Id = selected.Id;
            book.Title = title;
            book.Author = author;
            book.Description = description;
            book.Available = available;

            int pageCountNum;
            float priceNum;
            int quantityNum;

            if (!int.TryParse(pageCount, out pageCountNum))
            {
                txtPageCount.Focus();
                errorMessage = "Page Count must be a whole number.";
                return false;
            }
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
    }
}

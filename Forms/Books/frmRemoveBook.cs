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
    public partial class frmRemoveBook : Form
    {
        IDBContext db;
        Book selected = null;

        public frmRemoveBook()
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
                UpdateIdSelection(txtTitleSearch.Text);
                return;
            }

            this.selected = selected;

            grpBook.Text = "Remove " + selected.ToString();

            txtTitle.Text = selected.Title;
            txtAuthor.Text = selected.Author;
            txtDescription.Text = selected.Description;
            txtPageCount.Text = selected.PageCount.ToString();
            txtPrice.Text = selected.Price.ToString();
            txtQuantity.Text = selected.Quantity.ToString();
            txtISBN.Text = selected.ISBN.ToString();

            grpBook.Show();
        }

        public void RemoveSelected()
        {
            if (selected == null || selected.Status == 'N')
            {
                UpdateSelected(null);
                return;
            }

            var confirmation = MessageBox.Show("Are you sure you wish to remove this book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (confirmation == DialogResult.Yes)
            {
                db.RemoveBook(selected.BookId);
            }

            MessageBox.Show("The book: " + selected.ToString() + " has been removed.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateSelected(null);
            UpdateIdSelection(txtTitleSearch.Text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            RemoveSelected();
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

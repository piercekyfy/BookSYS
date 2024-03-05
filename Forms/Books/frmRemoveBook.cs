using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookSYS.Forms.Books
{
    public partial class frmRemoveBook : DBForm
    {
        private Book _selected = null;

        public frmRemoveBook()
        {
            InitializeComponent();

            //Utils.SetupSearch<Book>(txtTitleSearch, cboId, (title) => { return db.GetBooksByApproximateTitle(title); }, Select);
        }

        public void Remove()
        {
            if (_selected == null || _selected.Status == 'N')
            {
                Select(null);
                return;
            }

            var confirmation = MessageBox.Show("Are you sure you wish to remove this book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.No || confirmation == DialogResult.None)
                return;

            db.RemoveBook(_selected.BookId.Value);

            MessageBox.Show("The book: " + _selected.ToString() + " has been removed.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Select(null);
        }

        public void Select(Book selected)
        {
            this._selected = selected;
            if(selected == null)
            {
                txtTitleSearch.Text = "";
                cboId.Text = "";
                cboId.Items.Clear();
                grpBook.Hide();
                return;
            }

            this._selected = selected;

            grpBook.Text = "Remove " + selected.ToString();

            txtTitle.Text = selected.Title;
            txtAuthor.Text = selected.Author;
            txtDescription.Text = selected.Description;
            txtPublisher.Text = selected.Publisher;
            txtPrice.Text = selected.Price.ToString();
            txtQuantity.Text = selected.Quantity.ToString();
            txtISBN.Text = selected.ISBN.ToString();

            grpBook.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

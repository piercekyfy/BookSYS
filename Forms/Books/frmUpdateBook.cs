using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookSYS.Forms.Books
{
    public partial class frmUpdateBook : DBForm
    {
        private Dictionary<string, Control> _propertyMap;
        Book selected = null;

        public frmUpdateBook()
        {
            InitializeComponent();

            // Used to Focus on invalid properties through Book's validation method.
            _propertyMap = new Dictionary<string, Control>()
            {
                { nameof(Book.Title), txtTitle },
                { nameof(Book.Author), txtAuthor },
                { nameof(Book.Description), txtDescription },
                { nameof(Book.Publisher), txtPublisher },
                { nameof(Book.Price), txtPrice },
                { nameof(Book.Quantity), txtQuantity },
                { nameof(Book.ISBN), txtISBN },
            };
        }

        public void UpdateOptions(string title)
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

        private void UpdateSelected(Book selected)
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

        private void Update(Book selected)
        {
            if (selected == null)
                return;

            Book book = null;

            if (!ProcessInput(out book, out string invalidProperty, out string error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (_propertyMap.TryGetValue(invalidProperty, out Control control))
                {
                    control.Focus();
                }

                return;
            }

            db.UpdateBook(book);

            MessageBox.Show("The book: " + book.ToString() + " has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateSelected(null);
            UpdateOptions(txtTitleSearch.Text);
        }

        public bool ProcessInput(out Book book, out string invalidProperty, out string error)
        {
            book = null;

            int id = selected.BookId;
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string description = txtDescription.Text;
            string publisher = txtPublisher.Text;
            string price = txtPrice.Text;
            string quantity = txtQuantity.Text;
            string ISBN = txtISBN.Text;
            double priceNum;
            int quantityNum;

            if (!double.TryParse(price, out priceNum))
            {
                invalidProperty = nameof(Book.Price);
                error = "Price must be a decimal number.";
                return false;
            }
            if (!int.TryParse(quantity, out quantityNum))
            {
                invalidProperty = nameof(Book.Quantity);
                error = "Quantity must be a whole number.";
                return false;
            }

            Book validationBook = new Book(id, title, author, description, publisher, priceNum, quantityNum, ISBN);

            if (Book.Validate(validationBook, out invalidProperty, out error))
            {
                book = validationBook;
                return true;
            }
            return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Update(selected);
        }

        private void txtTitleSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitleSearch.Text))
                return;

            UpdateOptions(txtTitleSearch.Text);
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

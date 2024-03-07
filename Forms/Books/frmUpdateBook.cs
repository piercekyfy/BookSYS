using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace BookSYS.Forms.Books
{
    public partial class frmUpdateBook : DBForm
    {
        private Dictionary<string, Control> _propertyMap;
        private Book _selected = null;

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

           Utils.SetupSearch(txtTitleSearch, cboId, (title) => { return db.GetBooksByApproximateTitle(title); }, (idNamePair) =>
           {
               Select(db.GetBook(idNamePair.Id));
           });
        }

        public void Update()
        {
            if (_selected == null)
                return;

            Book book;
            if (!ProcessInput(out book, out string invalidProperty, out string error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (_propertyMap.TryGetValue(invalidProperty, out Control control))
                {
                    control.Focus();
                }

                return;
            }

            db.Save(book);

            MessageBox.Show("The book: " + book.ToString() + " has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Select(book);

            txtTitleSearch.Text = "";
            cboId.Text = "";
            cboId.Items.Clear();
        }

        private void Select(Book selected)
        {
            this._selected = selected;

            if (selected == null)
            {
                txtTitleSearch.Text = "";
                cboId.Text = "";
                cboId.Items.Clear();
                grpBook.Hide();
                return;
            }

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

        public bool ProcessInput(out Book book, out string invalidProperty, out string error)
        {
            book = null;

            int id = _selected.BookId.Value;
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

            Book validationBook = new Book(title, author, description, publisher, priceNum, quantityNum, ISBN);
            validationBook.BookId = id;

            if (Book.Validate(validationBook, out invalidProperty, out error))
            {
                book = validationBook;
                return true;
            }
            return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e) => Update();

        private void mnuExit_Click(object sender, EventArgs e) => Close();
    }
}

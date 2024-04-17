using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookSYS.Forms.Books
{
    public partial class frmCreateBook : DBForm
    {
        private Dictionary<string, Control> _propertyMap;

        public frmCreateBook()
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

        public void Create()
        {
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

            try
            {
                db.Save(book);
            } catch (Exception)
            {
                MessageBox.Show("Failed to save book, please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The book: " + book.ToString() + " has been added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInputs();
        }

        public bool ProcessInput(out Book book, out string invalidProperty, out string error)
        {
            book = null;
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

            if(Book.Validate(validationBook, out invalidProperty, out error))
            {
                book = validationBook;
                return true;
            }
            return false;
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

        private void btnSubmit_Click(object sender, EventArgs e) => Create();

        private void mnuExit_Click(object sender, EventArgs e) => Close();
    }
}

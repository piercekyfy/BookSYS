using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BookSYS.Forms.Clients
{
    public partial class frmCreateOrder : DBForm
    {
        Order order = new Order();
        Client selectedClient = null;
        Book selectedBook = null;
        List<BookOrder> selectedBooks = new List<BookOrder>();

        public frmCreateOrder()
        {
            InitializeComponent();

            Utils.SetupSearch(txtNameSearch, cboClientId, (name) => { return db.GetClientsByApproximateName(name); }, (idNamePair) =>
            {
                UpdateSelectedClient(db.GetClient(idNamePair.Id));
            });

            Utils.SetupSearch(txtTitleSearch, cboBookId, (title) => { return db.GetBooksByApproximateTitle(title); }, (idNamePair) =>
            {
                UpdateSelectedBook(db.GetBook(idNamePair.Id));
            });
        }

        public void UpdateSelectedClient(Client selected)
        {
            if (selected == null)
            {
                this.selectedClient = null;
                txtNameSearch.Text = "";
                cboClientId.Text = "";
                grpOrder.Hide();
                return;
            }

            Reset();
            this.selectedClient = selected;
            

            grpOrder.Show();
        }

        public void UpdateSelectedBook(Book selected)
        {
            if (selected == null)
            {
                this.selectedBook = null;
                txtTitleSearch.Text = "";
                cboBookId.Text = "";
                return;
            }

            selectedBook = selected;
        }

        public void Reset()
        {
            selectedClient = null;
            selectedBook = null;
            selectedBooks.Clear();
            lstBooks.Items.Clear();
            txtTitleSearch.Clear();
            cboBookId.Text = string.Empty;
            cboBookRevId.Text = string.Empty;
            txtTitleSearch.Text = string.Empty;
            cboBookRevId.Items.Clear();
            cboBookId.Items.Clear();
            lblTotal.Text = "Total: 000000.00";
        }

        public void UpdateBookList()
        {
            cboBookRevId.SelectedIndex = -1;
            cboBookRevId.Items.Clear();
            cboBookId.Items.Clear();
            txtNameSearch.Clear();
            txtQuantity.Clear();

            lstBooks.Items.Clear();

            lblTotal.Text = "Total: " + CalculateTotal().ToString();
        }

        public double CalculateTotal()
        {
            double totalPrice = 0;
            foreach (BookOrder bookOrder in selectedBooks)
            {
                Book book = db.GetBook(bookOrder.BookId);

                lstBooks.Items.Add(bookOrder);
                cboBookRevId.Items.Add(book);
                totalPrice += bookOrder.SalePrice * bookOrder.Quantity;
            }
            return totalPrice;
        }

        public void PlaceOrder()
        {
            if(selectedBooks.Count <= 0)
            {
                MessageBox.Show("No books in cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmation = MessageBox.Show("Are you sure you wish to place this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.No)
                return;

            order.ClientId = selectedClient.ClientId.Value;
            order.OrderDate = DateTime.UtcNow;
            order.Total = CalculateTotal();
            order.Status = 'U';

            string infoDisplay = $"Placed {order}, including:\n";

            db.Insert(order, selectedBooks);

            foreach (BookOrder bookOrder in selectedBooks)
            {
                Book book = db.GetBook(bookOrder.BookId);

                book.Quantity -= bookOrder.Quantity;

                db.Save(book);

                infoDisplay += $"{bookOrder}\n";
            }

            MessageBox.Show(infoDisplay, "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Reset();
            UpdateSelectedClient(null);
        }

        public void AddBookToCart(Book book)
        {
            int quantity;

            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Quantity must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ProcessInput(book, quantity, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BookOrder bookOrder = new BookOrder();
            bookOrder.BookId = book.BookId.Value;
            bookOrder.SalePrice = book.Price;
            bookOrder.Quantity = quantity;

            selectedBooks.Add(bookOrder);

            UpdateBookList();
        }

        public void RemoveBookFromCart(Book book)
        {
            foreach(BookOrder bookOrder in selectedBooks)
            {
                Book bookOrderBook = db.GetBook(bookOrder.BookId);

                if(bookOrderBook.BookId.Value == book.BookId.Value)
                {
                    selectedBooks.Remove(bookOrder);
                    break;
                }
            }

            UpdateBookList();
        }

        private bool ProcessInput(Book book, int quantity, out string errorMessage)
        {
            if (book.Quantity < 0)
            {
                errorMessage = "Selected book is out of stock.";
                return false;
            }
            if (quantity > book.Quantity)
            {
                errorMessage = "Selected book has a quantity of " + book.Quantity + " in stock. This exceeds the chosen quantity (" + quantity + ").";
                txtQuantity.Text = book.Quantity.ToString();
                return false;
            }

            foreach (BookOrder existingBookOrder in selectedBooks)
            {
                Book bookOrderBook = db.GetBook(existingBookOrder.BookId);

                if (bookOrderBook.BookId.Value == book.BookId.Value)
                {
                    errorMessage = "Selected book already exists in cart. To modify quantity, remove and re-add it.";
                    return false;
                }
            }

            errorMessage = null;
            return true;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (selectedBook == null)
            {
                MessageBox.Show("Select a book before ordering.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AddBookToCart(selectedBook);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(cboBookRevId.SelectedIndex == -1)
            {
                return;
            }

            RemoveBookFromCart((Book)cboBookRevId.SelectedItem);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

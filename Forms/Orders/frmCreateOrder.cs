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
using System.Windows.Forms.VisualStyles;

namespace BookSYS.Forms.Clients
{
    public partial class frmCreateOrder : Form
    {
        IDBContext db;
        Order order = new Order();
        Client selectedClient = null;
        Book selectedBook = null;
        List<BookOrder> selectedBooks = new List<BookOrder>();

        public frmCreateOrder()
        {
            InitializeComponent();

            db = null;// DummyDBSingleton.Instance;

            IEnumerable<Client> clients = db.GetClients();

            if (clients.Count() == 0)
            {
                MessageBox.Show("No Clients exist in file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #region Existing Client Selection
        public void UpdateClientIdSelection(string name)
        {
            cboClientId.Items.Clear();

            List<Client> clients = null;// db.GetClientsByApproximateName(name).ToList();

            if (clients.Count() == 0)
                return;

            foreach (Client client in clients)
            {
                cboClientId.Items.Add(client);
            }
        }

        public void UpdateSelectedClient(Client selected)
        {
            if (selected == null)
            {
                this.selectedClient = null;
                cboClientId.Text = "";
                grpOrder.Hide();
                UpdateClientIdSelection(txtNameSearch.Text);
                return;
            }

            Reset();
            this.selectedClient = selected;
            

            grpOrder.Show();
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNameSearch.Text)) 
                return;

            UpdateClientIdSelection(txtNameSearch.Text);
        }

        private void cboClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientId.SelectedIndex == -1)
            {
                UpdateSelectedClient(null);
            }
            else
            {
                UpdateSelectedClient((Client)cboClientId.SelectedItem);
            }
        }

        #endregion

        #region Existing Book Selection

        public void UpdateBookIdSelection(string title)
        {
            throw new NotImplementedException();
            //cboBookId.Items.Clear();

            //List<Book> books = db.GetBooksByApproximateTitle(title).ToList();

            //if (books.Count() == 0)
            //    return;

            //foreach (Book book in books)
            //{
            //    cboBookId.Items.Add(book);
            //}
        }

        public void UpdateSelectedBook(Book selected)
        {
            if (selected == null)
            {
                this.selectedBook = null;
                cboBookId.Text = "";
                UpdateBookIdSelection(txtTitleSearch.Text);
                return;
            }

            selectedBook = selected;
        }

        private void txtTitleSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitleSearch.Text))
                return;

            UpdateBookIdSelection(txtTitleSearch.Text);
        }

        private void cboBookId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientId.SelectedIndex == -1)
            {
                UpdateSelectedBook(null);
            }
            else
            {
                UpdateSelectedBook((Book)cboBookId.SelectedItem);
            }
        }

        #endregion

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
                lstBooks.Items.Add(bookOrder);
                cboBookRevId.Items.Add(bookOrder.Book);
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

            order.OrderId = db.NextOrderId();
            order.Client = selectedClient;
            order.OrderDate = DateTime.UtcNow;
            order.Total = CalculateTotal();
            order.Status = 'U';

            db.AddOrder(order);

            string infoDisplay = $"Placed {order}, including:\n";

            foreach (BookOrder bookOrder in selectedBooks)
            {
                db.AddBookOrder(bookOrder);
                bookOrder.Book.Quantity -= bookOrder.Quantity;
                // TODO: Replace with new book update methods
                //db.UpdateBook(bookOrder.Book);

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

            BookOrder bookOrder = new BookOrder(order, book, book.Price, quantity);

            selectedBooks.Add(bookOrder);

            UpdateBookList();
        }

        public void RemoveBookFromCart(Book book)
        {
            foreach(BookOrder bookOrder in selectedBooks)
            {
                if(bookOrder.Book == book)
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
                if (existingBookOrder.Book == book)
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

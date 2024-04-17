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
        List<BookOrder> selectedBookOrders = new List<BookOrder>();

        public frmCreateOrder()
        {
            InitializeComponent();

            Utils.SetupSearch(txtNameSearch, cboClientId, (name) => { return db.GetClientsByApproximateName(name); }, (idNamePair) =>
            {
                SelectClient(db.GetClient(idNamePair.Id));
            });

            Utils.SetupSearch(txtTitleSearch, cboBookId, (title) => { return db.GetBooksByApproximateTitle(title); }, (idNamePair) =>
            {
                SelectBook(db.GetBook(idNamePair.Id));
            });

            dgBookOrders.Columns.Add("OrderId", "Order Id");
            dgBookOrders.Columns.Add("BookId", "Book Id");
            dgBookOrders.Columns.Add("Title", "Title");
            dgBookOrders.Columns.Add("Author", "Author");
            dgBookOrders.Columns.Add("SalePrice", "Sale Price (€)");
            dgBookOrders.Columns.Add("Quantity", "Quantity");
        }

        public void SelectClient(Client selected)
        {
            if (selected == null)
            {
                this.selectedClient = null;
                cboClientId.Items.Clear();
                cboClientId.Text = String.Empty;
                dgBookOrders.Columns.Clear();
                grpOrder.Hide();
                return;
            }

            this.selectedClient = selected;

            grpOrder.Show();
        }

        public void SelectBook(Book selected)
        {
            if (selected == null)
            {
                this.selectedBook = null;
                txtTitleSearch.Text = "";
                cboBookId.Text = "";
                txtQuantity.Text = "1";
                return;
            }

            selectedBook = selected;
        }

        public double GetTotal(List<BookOrder> bookOrders)
        {
            double total = 0;

            foreach (BookOrder bookOrder in bookOrders)
            {
                total += bookOrder.SalePrice * bookOrder.Quantity;
            }

            return total;
        }

        public void UpdateContents(List<BookOrder> bookOrders)
        {
            Utils.PopulateBookOrderDataGridView(dgBookOrders, bookOrders, (i) => { return db.GetBook(i); });

            cboBookRevId.Items.Clear();

            foreach (BookOrder bookOrder in bookOrders)
            {
                Book book = db.GetBook(bookOrder.BookId);

                cboBookRevId.Items.Add(book);
            }

            lblTotal.Text = "Total: €" + GetTotal(bookOrders);
        }

        public void PlaceOrder()
        {
            if(selectedBookOrders.Count <= 0)
            {
                MessageBox.Show("No books in cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmation = MessageBox.Show("Are you sure you wish to place this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.No)
                return;

            order.ClientId = selectedClient.ClientId.Value;
            order.OrderDate = DateTime.UtcNow;
            order.Total = GetTotal(selectedBookOrders);
            order.Status = 'U';

            string infoDisplay = $"Placed {order}, including:\n";

            try
            {
                db.Insert(order, selectedBookOrders);

                foreach (BookOrder bookOrder in selectedBookOrders)
                {
                    Book book = db.GetBook(bookOrder.BookId);

                    book.Quantity -= bookOrder.Quantity;

                    db.Save(book);

                    infoDisplay += $"{bookOrder}\n";
                }
            } catch(Exception)
            {
                MessageBox.Show("Failed to create order, please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(infoDisplay, "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SelectBook(null);
            SelectClient(null);
        }

        public void AddBook(Book book)
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

            foreach(BookOrder existingBookOrder in selectedBookOrders)
            {
                if(book.BookId == existingBookOrder.BookId)
                {
                    MessageBox.Show("Selected book already exists in cart. To modify quantity, remove and re-add it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            BookOrder bookOrder = new BookOrder();
            bookOrder.OrderId = -1;
            bookOrder.BookId = book.BookId.Value;
            bookOrder.SalePrice = book.Price;
            bookOrder.Quantity = quantity;

            selectedBookOrders.Add(bookOrder);

            UpdateContents(selectedBookOrders);
        }

        public void RemoveBook(Book book)
        {
            foreach(BookOrder bookOrder in selectedBookOrders)
            {
                if(bookOrder.BookId == book.BookId.Value)
                {
                    selectedBookOrders.Remove(bookOrder);
                    break;
                }
            }

            UpdateContents(selectedBookOrders);
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

            AddBook(selectedBook);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(cboBookRevId.SelectedIndex == -1)
            {
                return;
            }

            RemoveBook((Book)cboBookRevId.SelectedItem);
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

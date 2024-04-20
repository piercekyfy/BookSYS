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
    public partial class frmCancelOrder : DBForm
    {
        Client selectedClient = null;
        Order selectedOrder = null;
        List<BookOrder> selectedBookOrders = null;

        public frmCancelOrder()
        {
            InitializeComponent();

            Utils.SetupSearch(txtNameSearch, cboClientId, (name) => { return db.GetClientsByApproximateName(name); }, (idNamePair) =>
            {
                SelectClient(db.GetClient(idNamePair.Id));
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
                cboOrderId.Text = String.Empty;
                cboOrderId.Items.Clear();

                grpOrder.Enabled = false;
                dgBookOrders.Rows.Clear();
                return;
            }

            this.selectedClient = selected;

            foreach(Order order in db.GetOrdersByClient(selectedClient.ClientId.Value))
            {
                if(order.Status == 'U')
                {
                    cboOrderId.Items.Add(order);
                }
            }

            grpOrder.Enabled = true;
        }

        public void SelectOrder(Order order)
        {
            if(order == null)
            {
                selectedOrder = null;
                selectedBookOrders.Clear();
                dgBookOrders.Rows.Clear();
                cboOrderId.Items.Clear();
                cboOrderId.Text = String.Empty;

                return;
            }

            selectedOrder = order;
            selectedBookOrders = db.GetBookOrdersByOrder(selectedOrder.OrderId.Value).ToList();

            UpdateContents(selectedBookOrders);
        }

        public double GetTotal(List<BookOrder> bookOrders)
        {
            double total = 0;

            foreach(BookOrder bookOrder in bookOrders)
            {
                total += bookOrder.SalePrice * bookOrder.Quantity;
            }

            return total;
        }

        public void UpdateContents(List<BookOrder> bookOrders)
        {
            Utils.PopulateBookOrderDataGridView(dgBookOrders, bookOrders, (i) => { return db.GetBook(i); });

            lblTotal.Text = "Total: €" + GetTotal(bookOrders);
        }

        private void cboOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOrderId.SelectedIndex == -1)
                return;

            SelectOrder((Order)cboOrderId.SelectedItem);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                db.DeleteOrder(selectedOrder.OrderId.Value);

                foreach (BookOrder bookOrder in selectedBookOrders)
                {
                    Book book = db.GetBook(bookOrder.BookId);

                    book.Quantity += bookOrder.Quantity;

                    db.Save(book);
                }
            } catch (Exception)
            {
                MessageBox.Show("Failed to cancel order, please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"{selectedOrder} has been cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SelectOrder(null);
            SelectClient(null);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

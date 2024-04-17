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
    public partial class frmListOrders : DBForm
    {
        Client selectedClient = null;
        Order selectedOrder = null;

        public frmListOrders()
        {
            InitializeComponent();

            Utils.SetupSearch(txtNameSearch, cboClientId, (name) => { return db.GetClientsByApproximateName(name); }, (idNamePair) =>
            {
                SelectClient(db.GetClient(idNamePair.Id));
            });

            dgOrders.Columns.Add("OrderId", "Order Id");
            dgOrders.Columns.Add("OrderDate", "Date");
            dgOrders.Columns.Add("Total", "Total (€)");
            dgOrders.Columns.Add("Status", "Status");

            dgBookOrders.Columns.Add("OrderId", "Order Id");
            dgBookOrders.Columns.Add("BookId", "Book Id");
            dgBookOrders.Columns.Add("Title", "Title");
            dgBookOrders.Columns.Add("Author", "Author");
            dgBookOrders.Columns.Add("SalePrice", "Sale Price (€)");
            dgBookOrders.Columns.Add("Quantity", "Quantity");
        }

        public void SelectClient(Client selected)
        {
            dgOrders.Rows.Clear();
            dgBookOrders.Rows.Clear();

            if (selected == null)
            {
                selectedClient = null;
                selectedOrder = null;
                cboClientId.Text = "";
                grpOrder.Hide();
                return;
            }

            this.selectedClient = selected;

            Utils.PopulateOrderDataGridView(dgOrders, db.GetOrdersByClient(selectedClient.ClientId.Value).ToList());

            grpOrder.Show();
        }

        private void SelectOrder(Order order)
        {
            if (order == null)
                return;

            selectedOrder = order;
            
            grpOrderSpecific.Show();

            lblStatus.Text = "Status: " + (order.Status == 'U' ? "Undispatched" : order.Status == 'D' ? "Dispatched" : order.Status == 'P' ? "Paid" : "Cancelled");
            lblTotal.Text = "Total: " + order.Total;

            FillBookList(db.GetBookOrdersByOrder(order.OrderId.Value).ToList());
        }

        private void FillBookList(List<BookOrder> bookOrders)
        {
            libBooks.Items.Clear();

            foreach (BookOrder bookOrder in bookOrders)
            {
                libBooks.Items.Add(bookOrder);
            }

            lblTotal.Text = "Total: " + selectedOrder.Total;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void libOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (libOrders.SelectedIndex == -1)
                return;

            SetSelectedOrder((Order)libOrders.SelectedItem);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

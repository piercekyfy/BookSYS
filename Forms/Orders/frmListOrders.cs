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
        List<Order> orders = new List<Order>();
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

                dgOrders.Rows.Clear();
                orders.Clear();
                grpOrder.Hide();

                SelectOrder(null);

                return;
            }

            this.selectedClient = selected;

            orders = db.GetOrdersByClient(selectedClient.ClientId.Value).ToList();

            Utils.PopulateOrderDataGridView(dgOrders, orders);

            grpOrder.Show();
        }

        private void SelectOrder(Order order)
        {
            if (order == null)
            {
                grpOrderSpecific.Hide();
                dgBookOrders.Rows.Clear();
            }

            selectedOrder = order;

            grpOrderSpecific.Show();

            UpdateContents(db.GetBookOrdersByOrder(order.OrderId.Value).ToList());

        }

        public void UpdateContents(List<BookOrder> bookOrders)
        {
            Utils.PopulateBookOrderDataGridView(dgBookOrders, bookOrders, (i) => { return db.GetBook(i); });
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Order order = orders.Where(x => x.OrderId == (int)dgOrders.Rows[e.RowIndex].Cells["OrderId"].Value).FirstOrDefault();

            if (order == null)
                return;

            SelectOrder(order);
        }
    }
}

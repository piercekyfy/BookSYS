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
                UpdateSelectedClient(db.GetClient(idNamePair.Id));
            });
        }

        #region Existing Client Selection
        public void UpdateClientIdSelection(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateSelectedClient(Client selected)
        {
            libOrders.Items.Clear();
            libBooks.Items.Clear();
            if (selected == null)
            {
                this.selectedClient = null;
                cboClientId.Text = "";
                grpOrder.Hide();
                UpdateClientIdSelection(txtNameSearch.Text);
                return;
            }

            this.selectedClient = selected;

            foreach(Order order in db.GetOrdersByClient(selectedClient.ClientId.Value))
            {
                libOrders.Items.Add(order);
            }

            ResetOrder();
            grpOrder.Show();
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboClientId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void ResetOrder()
        {
            selectedOrder = null;
            libBooks.Items.Clear();
            selectedOrder = null;
            lblStatus.Text = "Status: Undispatched.";
            lblTotal.Text = "Total: 000000.00";
            grpOrderSpecific.Hide();
        }

        private void SetSelectedOrder(Order order)
        {
            ResetOrder();
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

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
    public partial class frmProcessPayment : Form
    {
        IDBContext db;

        Client selectedClient = null;
        Order selectedOrder = null;

        public frmProcessPayment()
        {
            InitializeComponent();

            db = DummyDbSingleton.Instance;

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

            List<Client> clients = db.GetClientsByApproximateName(name).ToList();

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

            foreach(Order order in db.GetOrdersByClient(selectedClient))
            {
                if(order.Paid == false && order.Status != 'C')
                {
                    cboOrderId.Items.Add(order);
                }
            }

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

        public void Reset()
        {
            selectedOrder = null;
            selectedClient = null;
            libBooks.Items.Clear();
            cboOrderId.Text = string.Empty;
            cboOrderId.Items.Clear();
            lblTotal.Text = "Total: 000000.00";
        }

        public void FillBookList(List<BookOrder> bookOrders)
        {
            libBooks.Items.Clear();

            double totalPrice = 0;
            foreach(BookOrder bookOrder in bookOrders)
            {
                libBooks.Items.Add(bookOrder);
                totalPrice += bookOrder.SalePrice * bookOrder.Quantity;
            }

            lblTotal.Text = "Total: " + totalPrice.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            db.PayOrder(selectedOrder.OrderId);

            MessageBox.Show($"{selectedOrder} has been registered as paid.", "Payment Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Reset();
            UpdateSelectedClient(null);
        }

        private void cboOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOrderId.SelectedIndex == -1)
                return;

            selectedOrder = (Order)cboOrderId.SelectedItem;

            FillBookList(db.GetBookOrdersByOrder(selectedOrder).ToList());
        }
    }
}

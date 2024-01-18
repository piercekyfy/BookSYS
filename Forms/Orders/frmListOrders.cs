﻿using BookSYS.Models;
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
    public partial class frmListOrders : Form
    {
        IDBContext db;

        Client selectedClient = null;
        Order selectedOrder = null;

        public frmListOrders()
        {
            InitializeComponent();

            db = DummyDBSingleton.Instance;

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

            foreach(Order order in db.GetOrdersByClient(selectedClient))
            {
                libOrders.Items.Add(order);
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

        private void SetSelectedOrder(Order order)
        {
            libBooks.Items.Clear();
            if (order == null)
            {
                selectedOrder= null;
                lblStatus.Text = "Status: Undispatched.";
                lblTotal.Text = "Total: 000000.00";
                return;
            }

            selectedOrder = order;

            double total = 0;
            foreach(BookOrder book in db.GetBookOrdersByOrder(order))
            {
                libBooks.Items.Add(book);
                total += book.SalePrice * book.Quantity;
            }

            lblStatus.Text = "Status: " + (order.Status == 'U' ? "Undispatched" : order.Status == 'D' ? "Dispatched" : order.Status == 'P' ? "Paid" : "Cancelled");
            lblTotal.Text = "Total: " + total;
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            db.DispatchOrder(selectedOrder.OrderId);

            MessageBox.Show($"{selectedOrder} has been dispatched.", "Dispatched", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateSelectedClient(null);
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

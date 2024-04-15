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
        IDBContext db;

        Client selectedClient = null;
        Order selectedOrder = null;

        public frmCancelOrder()
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

            foreach(Order order in db.GetOrdersByClient(selectedClient.ClientId.Value))
            {
                if(order.Status == 'U')
                {
                    cboOrderId.Items.Add(order);
                }
            }

            grpOrder.Show();
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboClientId_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            lblTotal.Text = "Total: " + selectedOrder.Total;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            db.DeleteOrder(selectedOrder.OrderId.Value);

            foreach(BookOrder bookOrder in db.GetBookOrdersByOrder(selectedOrder.OrderId.Value))
            {
                Book book = db.GetBook(bookOrder.BookId);

                book.Quantity += bookOrder.Quantity;

                db.Save(book);
            }

            MessageBox.Show($"{selectedOrder} has been cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Reset();
            UpdateSelectedClient(null);
        }

        private void cboOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOrderId.SelectedIndex == -1)
                return;

            selectedOrder = (Order)cboOrderId.SelectedItem;

            FillBookList(db.GetBookOrdersByOrder(selectedOrder.OrderId.Value).ToList());
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

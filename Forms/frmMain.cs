using BookSYS.Forms.Books;
using BookSYS.Forms.Clients;
using BookSYS.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSYS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Book

        private void mnuCreateBook_Click(object sender, EventArgs e)
        {
            Form next = new frmCreateBook();
            next.Show();
        }

        private void mnuUpdateBook_Click(object sender, EventArgs e)
        {
            Form next = new frmUpdateBook();
            next.Show();
        }

        private void mnuRemoveBook_Click(object sender, EventArgs e)
        {
            Form next = new frmRemoveBook();
            next.Show();
        }

        #endregion

        #region Client
        private void mnuOpenAccount_Click(object sender, EventArgs e)
        {
            Form next = new frmOpenClientAccount();
            next.Show();
        }

        private void mnuUpdateAccount_Click(object sender, EventArgs e)
        {
            Form next = new frmUpdateClientAccount();
            next.Show();
        }

        private void mnuCloseAccount_Click(object sender, EventArgs e)
        {
            Form next = new frmCloseClientAccount();
            next.Show();
        }

        #endregion

        #region Order
        private void mnuCreateOrder_Click(object sender, EventArgs e)
        {
            Form next = new frmCreateOrder();
            next.Show();
        }

        private void mnuDispatchOrder_Click(object sender, EventArgs e)
        {
            Form next = new frmDispatchOrder();
            next.Show();
        }

        private void mnuProcessPayment_Click(object sender, EventArgs e)
        {
            Form next = new frmProcessPayment();
            next.Show();
        }

        private void mnuCancelOrder_Click(object sender, EventArgs e)
        {
            Form next = new frmCancelOrder();
            next.Show();
        }

        private void listOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form next = new frmListOrders();
            next.Show();
        }


        #endregion
        private void mnuBookPopularity_Click(object sender, EventArgs e)
        {
            Form next = new frmBookPopularity();
            next.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

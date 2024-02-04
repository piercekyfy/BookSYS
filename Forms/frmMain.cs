﻿using BookSYS.Forms.Books;
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
using BookSYS.Forms;

namespace BookSYS.Forms
{
    public partial class frmMain : Form
    {
        private IDBContext dbContext = null;

        public frmMain()
        {
            InitializeComponent();

            picDBConnection.BackColor = Color.Red;
            dbContext = DummyDBSingleton.Instance;
        }

        private void mnuDBConnect_Click(object sender, EventArgs e)
        {
            var connectionForm = new frmDBConnect("studentoracle: 1521/orcl", (conn) =>
            {
                dbContext = new DBService(conn);
                picDBConnection.BackColor = Color.LimeGreen;
            });

            connectionForm.ShowDialog(this);
        }

        private void OpenDBForm(DBForm form)
        {
            if(dbContext == null)
            {
                MessageBox.Show("Database connection not found. Have you logged in?", "No DB Connection!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            form.RegisterDBContext(dbContext);
            form.Show(this);
        }

        #region Book

        private void mnuCreateBook_Click(object sender, EventArgs e) => OpenDBForm(new frmCreateBook());

        private void mnuUpdateBook_Click(object sender, EventArgs e) => OpenDBForm(new frmUpdateBook());

        private void mnuRemoveBook_Click(object sender, EventArgs e) => OpenDBForm(new frmRemoveBook());

        #endregion

        #region Client
        private void mnuOpenAccount_Click(object sender, EventArgs e) => OpenDBForm(new frmOpenClientAccount());

        private void mnuUpdateAccount_Click(object sender, EventArgs e)
        {
            Form next = new frmUpdateClientAccount();
            next.Show(this);
        }

        private void mnuCloseAccount_Click(object sender, EventArgs e)
        {
            Form next = new frmCloseClientAccount();
            next.Show(this);
        }

        #endregion

        #region Order
        private void mnuCreateOrder_Click(object sender, EventArgs e)
        {
            Form next = new frmCreateOrder();
            next.Show(this);
        }

        private void mnuDispatchOrder_Click(object sender, EventArgs e)
        {
            Form next = new frmDispatchOrder();
            next.Show(this);
        }

        private void mnuProcessPayment_Click(object sender, EventArgs e)
        {
            Form next = new frmProcessPayment();
            next.Show(this);
        }

        private void mnuCancelOrder_Click(object sender, EventArgs e)
        {
            Form next = new frmCancelOrder();
            next.Show(this);
        }

        private void listOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form next = new frmListOrders();
            next.Show(this);
        }


        #endregion
        private void mnuBookPopularity_Click(object sender, EventArgs e)
        {
            Form next = new frmBookPopularity();
            next.Show(this);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

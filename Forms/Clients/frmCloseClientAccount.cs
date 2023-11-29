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

namespace BookSYS.Forms.Clients
{
    public partial class frmCloseClientAccount : Form
    {
        IDBContext db;
        Client selected = null;

        public frmCloseClientAccount()
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
        public void UpdateIdSelection(string name)
        {
            cboId.Items.Clear();

            List<Client> clients = db.GetClientsByApproximateName(name).ToList();

            if (clients.Count() == 0)
                return;

            foreach (Client client in clients)
            {
                cboId.Items.Add(client);
            }
        }

        public void UpdateSelected(Client selected)
        {
            if (selected == null)
            {
                this.selected = null;
                grpClient.Hide();
                UpdateIdSelection(txtNameSearch.Text);
                return;
            }

            this.selected = selected;

            grpClient.Text = "Update " + selected.ToString();


            txtName.Text = selected.Name;
            txtAdd_Street.Text = selected.Street;
            txtAdd_City.Text = selected.City;
            txtAdd_County.Text = selected.County;
            txtAdd_Eircode.Text = selected.Eircode;
            txtEmail.Text = selected.Email;
            txtPhone.Text = selected.Phone;

            grpClient.Show();
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNameSearch.Text))
                return;

            UpdateIdSelection(txtNameSearch.Text);
        }

        private void cboId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboId.SelectedIndex == -1)
            {
                UpdateSelected(null);
            }
            else
            {
                UpdateSelected((Client)cboId.SelectedItem);
            }
        }

        #endregion

        public void RemoveSelected()
        {
            if (selected == null)
            {
                UpdateSelected(null);
                return;
            }

            var confirmation = MessageBox.Show("Are you sure you wish to close this client's account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                db.RemoveClient(selected.ClientId);
            }

            MessageBox.Show("The client account: " + selected.ToString() + " has been closed.", "Closed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateSelected(null);
            UpdateIdSelection(txtNameSearch.Text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            RemoveSelected();
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtAdd_Street.Clear();
            txtAdd_City.Clear();
            txtAdd_County.Clear();
            txtAdd_Eircode.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }
    }
}

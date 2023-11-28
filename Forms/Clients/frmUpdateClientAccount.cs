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
    public partial class frmUpdateClientAccount : Form
    {
        IDBContext db;
        Client selected = null;

        public frmUpdateClientAccount()
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

        public void Update(Client client)
        {
            if (client == null)
                return;

            Client newClient = null;

            if (!ProcessInput(out newClient, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.UpdateClient(newClient);
            MessageBox.Show("The client account: " + client.ToString() + " has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateSelected(null);
            UpdateIdSelection(txtNameSearch.Text);
        }

        public bool ProcessInput(out Client newClient, out string errorMessage)
        {
            newClient = null;
            errorMessage = null;

            #region Check if fields are empty.

            if (!Utils.ValidateFilled(new List<TextBox> { txtName, txtAdd_Street, txtAdd_City, txtAdd_County, txtAdd_Eircode, txtEmail, txtPhone }, out TextBox firstEmpty))
            {
                firstEmpty.Focus();
                errorMessage = "Field cannot be empty.";
                return false;
            }

            #endregion

            string name = txtName.Text;
            string street = txtAdd_Street.Text;
            string city = txtAdd_City.Text;
            string county = txtAdd_County.Text;
            string eircode = txtAdd_Eircode.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            Client client = new Client();

            client.ClientId = selected.ClientId;
            client.Name = name;
            client.Street = street;
            client.City = city;
            client.County = county;
            client.Eircode = eircode;
            client.Email = email;
            client.Phone = phone;
            client.Status = 'O';

            // No Errors need to be checked for these inputs as the Client object checks all of them.

            errorMessage = null;
            newClient = client;

            return Client.VerifyClient(client, out errorMessage);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Update(selected);
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

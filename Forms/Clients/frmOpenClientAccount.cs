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
    public partial class frmOpenClientAccount : Form
    {
        IDBContext db;

        public frmOpenClientAccount()
        {
            InitializeComponent();

            db = DummyDBSingleton.Instance;
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

            client.ClientId = db.NextClientId();
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
            Client newClient;
            if (!ProcessInput(out newClient, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.AddClient(newClient);
            MessageBox.Show("The client account: " + newClient.ToString() + " has been opened.", "Opened", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
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

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

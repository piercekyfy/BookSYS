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
    public partial class frmUpdateClientAccount : DBForm
    {
        private Dictionary<string, Control> _propertyMap;
        Client _selected = null;

        public frmUpdateClientAccount()
        {
            InitializeComponent();

            // Used to Focus on invalid properties through Client's validation method.
            _propertyMap = new Dictionary<string, Control>()
            {
                { nameof(Client.Name), txtName },
                { nameof(Client.Street), txtAdd_Street },
                { nameof(Client.City), txtAdd_City },
                { nameof(Client.County), txtAdd_County },
                { nameof(Client.Eircode), txtAdd_Eircode },
                { nameof(Client.Email), txtEmail },
                { nameof(Client.Phone), txtPhone },
            };

            //Utils.SetupSearch<Client>(txtNameSearch, cboId, (title) => { return db.GetClientsByApproximateName(title); }, Select);
        }
        public void Update()
        {
            if (_selected == null)
                return;

            Client client;
            if (!ProcessInput(out client, out string invalidProperty, out string error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (_propertyMap.TryGetValue(invalidProperty, out Control control))
                {
                    control.Focus();
                }

                return;
            }

            db.UpdateClient(client);

            MessageBox.Show("The client account: " + client.ToString() + " has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Select(null);
        }

        public void Select(Client selected)
        {
            _selected = selected;
            if (selected == null)
            {
                txtNameSearch.Text = "";
                cboId.Text = "";
                cboId.Items.Clear();
                grpClient.Hide();
                return;
            }

            this._selected = selected;

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

        public bool ProcessInput(out Client client, out string invalidProperty, out string error)
        {
            client = null;

            int id = _selected.ClientId;
            string name = txtName.Text;
            string street = txtAdd_Street.Text;
            string city = txtAdd_City.Text;
            string county = txtAdd_County.Text;
            string eircode = txtAdd_Eircode.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            Client validationClient = new Client(id, name, street, city, county, eircode, email, phone);

            if (Client.Validate(validationClient, out invalidProperty, out error))
            {
                client = validationClient;
                return true;
            }
            return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

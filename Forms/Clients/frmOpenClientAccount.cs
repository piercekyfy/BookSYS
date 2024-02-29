using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSYS.Forms.Clients
{
    public partial class frmOpenClientAccount : DBForm
    {
        private Dictionary<string, Control> _propertyMap;

        public frmOpenClientAccount()
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
        }

        public void Open()
        {
            Client client;
            if(!ProcessInput(out client, out string invalidProperty, out string error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (_propertyMap.TryGetValue(invalidProperty, out Control control))
                {
                    control.Focus();
                }

                return;
            }

            db.AddClient(client);

            MessageBox.Show("The client account: " + client.ToString() + " has been opened.", "Opened", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        public bool ProcessInput(out Client client, out string invalidProperty, out string error)
        {
            client = null;

            string name = txtName.Text;
            string street = txtAdd_Street.Text;
            string city = txtAdd_City.Text;
            string county = txtAdd_County.Text;
            string eircode = txtAdd_Eircode.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            Client validationClient = new Client(name, street, city, county, eircode, email, phone);

            if(Client.Validate(validationClient, out invalidProperty, out error))
            {
                client = validationClient;
                return true;
            }
            return false;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmCloseClientAccount : DBForm
    {
        Client _selected = null;

        public frmCloseClientAccount()
        {
            InitializeComponent();

            Utils.SetupSearch(txtNameSearch, cboId, (name) => { return db.GetClientsByApproximateName(name); }, (idNamePair) =>
            {
                Select(db.GetClient(idNamePair.Id));
            });
        }

        public void Remove()
        {
            if (_selected == null)
            {
                Select(null);
                return;
            }

            var confirmation = MessageBox.Show("Are you sure you wish to close this client's account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.No || confirmation == DialogResult.None)
                return;

            try
            {
                db.DeleteClient(_selected.ClientId.Value);
            } catch (Exception)
            {
                MessageBox.Show("Failed to close client account, please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The client account: " + _selected.ToString() + " has been closed.", "Closed", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            grpClient.Text = "Remove " + selected.ToString();

            txtName.Text = selected.Name;
            txtAdd_Street.Text = selected.Street;
            txtAdd_City.Text = selected.City;
            txtAdd_County.Text = selected.County;
            txtAdd_Eircode.Text = selected.Eircode;
            txtEmail.Text = selected.Email;
            txtPhone.Text = selected.Phone;

            grpClient.Show();
        }

        
        private void btnSubmit_Click(object sender, EventArgs e) => Remove();

        private void mnuExit_Click(object sender, EventArgs e) => Close();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace BookSYS.Forms
{
    public partial class frmDBConnect : Form
    {
        static string portService = "1521/orcl";

        Action<OracleConnection> onDatabaseConnection;
        public frmDBConnect(Action<OracleConnection> onDatabaseConnect)
        {
            InitializeComponent();
            this.onDatabaseConnection = onDatabaseConnect;
        }
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtHost.Text))
            {
                MessageBox.Show("You must enter a hostname.", "No Hostname Specified", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHost.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("You must enter a password.", "No Password Specified", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }



            try
            {
                OracleConnection conn = new OracleConnection($"Data Source = {txtHost.Text}: {portService}; User ID = {txtUser.Text}; Password = {txtPass.Text};");
                conn.Open();

                if(conn.State == ConnectionState.Closed )
                {
                    MessageBox.Show("Failed to connect!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                conn.Close();

                onDatabaseConnection?.Invoke(conn);
                MessageBox.Show("Connected!", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            } catch (Exception ex)
            {
                MessageBox.Show("Failed to connect!", "General Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

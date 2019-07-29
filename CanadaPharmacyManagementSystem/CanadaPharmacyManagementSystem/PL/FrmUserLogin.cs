using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanadaPharmacyManagementSystem.BL;

namespace CanadaPharmacyManagementSystem.PL
{
    public partial class FrmUserLogin : Form
    {
        User user = new User();
        FrmMain myMain;

        public FrmUserLogin()
        {
            InitializeComponent();
        }

        public FrmUserLogin(FrmMain main)
        {
            InitializeComponent();
            myMain = main;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Fill User Name","Caution",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (txtUserPassword.Text == string.Empty)
            {
                MessageBox.Show("Fill User Password", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = user.UserLogin(txtUserName.Text, txtUserPassword.Text);
            if (dt.Rows.Count > 0)
            {
                this.Close();
                myMain.msBackUp.Enabled = true;
                myMain.msRestore.Enabled = true;
                myMain.msProducts.Enabled = true;
                myMain.msCustomers.Enabled = true;
                myMain.msSuppliers.Enabled = true;
                myMain.msUsers.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUserPassword.Focus();
            }
        }

        private void txtUserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmUserLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "Adel";
            txtUserPassword.Text = "123";
        }
    }
}

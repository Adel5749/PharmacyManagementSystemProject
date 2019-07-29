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
    public partial class FrmAddScientificName : Form
    {
        ScientificName scientific = new ScientificName();
        FrmBusiness frmBusiness = new FrmBusiness();

        public FrmAddScientificName()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtScientificName.Text == string.Empty)
            {
                MessageBox.Show("Fill the Name");
                return;
            }

            DataTable dt = scientific.ScientificNameVerifyName(0, txtScientificName.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This name is exist already");
                return;
            }

            scientific.ScientificNameAdd( txtScientificName.Text);
            MessageBox.Show("Added Successfully", "Add");
            frmBusiness.ClearTextBoxes(this.Controls);
        }
    }
}

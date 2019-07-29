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
    public partial class FrmAddActiveMaterial : Form
    {
        ActiveMaterial active = new ActiveMaterial();
        FrmBusiness frmBusiness = new FrmBusiness();

        public FrmAddActiveMaterial()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtActiveMaterialName.Text == string.Empty)
            {
                MessageBox.Show("Fill the name", "Check Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = active.ActiveMaterialVerifyName(1, txtActiveMaterialName.Text);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("This Name is already exist");
                return;
            }

            try
            {
                active.ActiveMaterialAdd(txtActiveMaterialName.Text, txtActiveMaterialDescription.Text);
                MessageBox.Show("Added Successfully");
                frmBusiness.ClearTextBoxes(this.Controls);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}

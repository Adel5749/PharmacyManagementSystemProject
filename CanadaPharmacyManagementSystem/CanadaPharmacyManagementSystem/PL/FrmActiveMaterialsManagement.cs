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
    public partial class FrmActiveMaterialsManagement : Form
    {
        ActiveMaterial active = new ActiveMaterial();
        FrmBusiness frmBusiness = new FrmBusiness();

        public FrmActiveMaterialsManagement()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dgvActiveMaterials.DataSource = active.ActiveMaterialSearch("");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvActiveMaterials.DataSource = active.ActiveMaterialSearch(txtSearch.Text);
        }

        private void dgvActiveMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvActiveMaterials.CurrentRow.Index != -1)
            {
                txtActiveMaterialID.Text = dgvActiveMaterials.CurrentRow.Cells[0].Value.ToString();
                txtActiveMaterialName.Text = dgvActiveMaterials.CurrentRow.Cells[1].Value.ToString();
                txtActiveMaterialDescription.Text = dgvActiveMaterials.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void dgvActiveMaterials_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvActiveMaterials.CurrentRow.Index != -1)
                {
                    txtActiveMaterialID.Text = dgvActiveMaterials.CurrentRow.Cells[0].Value.ToString();
                    txtActiveMaterialName.Text = dgvActiveMaterials.CurrentRow.Cells[1].Value.ToString();
                    txtActiveMaterialDescription.Text = dgvActiveMaterials.CurrentRow.Cells[2].Value.ToString();
                }
            }
            catch { }
        }

        private void btnEditMaterial_Click(object sender, EventArgs e)
        {
            if (txtActiveMaterialName.Text == string.Empty)
            {
                MessageBox.Show("Fill the name", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dt = active.ActiveMaterialVerifyName(Convert.ToInt16(txtActiveMaterialID.Text), txtActiveMaterialName.Text);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("This name is exist already", "Cauation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            active.ActiveMaterialUpdate(Convert.ToInt32(txtActiveMaterialID.Text),
                                        txtActiveMaterialName.Text, txtActiveMaterialDescription.Text);

            MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvActiveMaterials.DataSource = active.ActiveMaterialSearch("");
            frmBusiness.ClearTextBoxes(this.Controls);
        }

        private void btnDeleteSelectedMaterial_Click(object sender, EventArgs e)
        {
            if (dgvActiveMaterials.CurrentRow.Index > 0)
            {
                if(MessageBox.Show("Do U want to delete it?", "Caution",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        active.ActiveMaterialDelete(Convert.ToInt32(txtActiveMaterialID.Text));
                        MessageBox.Show("Deleted successfully");
                        dgvActiveMaterials.DataSource = active.ActiveMaterialSearch("");
                        frmBusiness.ClearTextBoxes(this.Controls);
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
        }
    }
}

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
    public partial class FrmScientificNamesManagement : Form
    {
        ScientificName scientific = new ScientificName();

        public FrmScientificNamesManagement()
        {
            InitializeComponent();
            dgvScientificNames.DataSource = scientific.ScientificNameSearch("");
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dgvScientificNames.DataSource = scientific.ScientificNameSearch("");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvScientificNames.DataSource = scientific.ScientificNameSearch(txtSearch.Text);
        }

        private void dgvScientificNames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScientificNames.CurrentRow.Index != -1)
            {
                txtScientificID.Text = dgvScientificNames.CurrentRow.Cells[0].Value.ToString();
                txtScientificName.Text = dgvScientificNames.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void dgvScientificNames_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtScientificID.Text = dgvScientificNames.CurrentRow.Cells[0].Value.ToString();
                txtScientificName.Text = dgvScientificNames.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {

            }

        }

        private void btnEditScientificName_Click(object sender, EventArgs e)
        {
            if (txtScientificName.Text == string.Empty)
            {
                MessageBox.Show("Fill the name");
                return;
            }

            DataTable dt = scientific.ScientificNameVerifyName(Convert.ToInt32(txtScientificID.Text), txtScientificName.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This name is exist already", "Caution");
                return;
            }
            try
            {
                scientific.ScientificNameUpdate(Convert.ToInt32(txtScientificID.Text), txtScientificName.Text);
                MessageBox.Show("Update Successfully", "Update");
                dgvScientificNames.DataSource = scientific.ScientificNameSearch("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteScientificName_Click(object sender, EventArgs e)
        {
            if (dgvScientificNames.CurrentRow.Index != -1)
            {

                if (MessageBox.Show("do U want to delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        scientific.ScientificNameDelete(Convert.ToInt32(txtScientificID.Text));
                        MessageBox.Show("Deleted Successfully", "Delete");
                        dgvScientificNames.DataSource = scientific.ScientificNameSearch("");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
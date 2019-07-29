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
    public partial class FrmCategoriesManagement : Form
    {
        Category category = new Category();

        public FrmCategoriesManagement()
        {
            InitializeComponent();
            dgvCategories.DataSource = category.CategoryGetAll();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            DataTable dt = category.CategoryGetAll();
            dgvCategories.DataSource = dt;
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryID.Text = dgvCategories.CurrentRow.Cells[0].Value.ToString();
            txtCategoryName.Text = dgvCategories.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCategories.DataSource = category.CategorySearch(txtSearch.Text);
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtCategoryID.Text = dgvCategories.CurrentRow.Cells[0].Value.ToString();
                txtCategoryName.Text = dgvCategories.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {

            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == string.Empty)
            {
                MessageBox.Show("Fill Category Name", "Caution", MessageBoxButtons.OK);
                return;
            }
            DataTable dt = category.CategoryVerifyName(txtCategoryName.Text);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("This name is exist already ", "Caution");
                return;
            }

            category.CategoryUpdate(Convert.ToInt32(txtCategoryID.Text), txtCategoryName.Text);
            MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvCategories.DataSource = category.CategoryGetAll();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow.Index != -1)
            {
                if(MessageBox.Show("do U want to delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        category.CategoryDelete(Convert.ToInt32(txtCategoryID.Text));
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}

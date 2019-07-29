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
    public partial class FrmAddCategory : Form
    {
        Category category = new Category();
        
        public FrmAddCategory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == string.Empty)
            {
                MessageBox.Show("Write the category name", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt= category.CategoryVerifyName(txtCategoryName.Text);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("This Name exists already");
                return;
            }
            
            category.CategoryAdd(txtCategoryName.Text);
            MessageBox.Show("Added Successfully", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCategoryName.Clear();
        }
    }
}

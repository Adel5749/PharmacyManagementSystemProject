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
    public partial class FrmProductsManagement : Form
    {
        Product product = new Product();
        
        public FrmProductsManagement()
        {
            InitializeComponent();
            btnGetAll_Click(null, null);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.Clear();
            DataTable dt = product.ProductSearch("");
            foreach(DataRow row in dt.Rows)
            {
                dgvProducts.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.Rows.Clear();
            DataTable dt = product.ProductSearch(txtSearch.Text);
            foreach (DataRow row in dt.Rows)
            {
                dgvProducts.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
            }
        }
    }
}

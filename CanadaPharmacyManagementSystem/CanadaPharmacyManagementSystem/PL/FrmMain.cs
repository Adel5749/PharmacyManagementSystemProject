using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanadaPharmacyManagementSystem.PL
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void msLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msLogin_Click(object sender, EventArgs e)
        {
            FrmUserLogin frm = new FrmUserLogin(this);
            frm.ShowDialog();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddCategory frm = new FrmAddCategory();
            frm.ShowDialog();
        }

        private void categoriesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCategoriesManagement().ShowDialog();
        }

        private void activeMaterialsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmActiveMaterialsManagement().ShowDialog();
        }

        private void msAddActiveMaterial_Click(object sender, EventArgs e)
        {
            new FrmAddActiveMaterial().ShowDialog();
        }

        private void addScientificNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAddScientificName().ShowDialog();
        }

        private void scientificNamesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmScientificNamesManagement().ShowDialog();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAddProduct().ShowDialog();
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmProductsManagement().ShowDialog();
        }
    }
}

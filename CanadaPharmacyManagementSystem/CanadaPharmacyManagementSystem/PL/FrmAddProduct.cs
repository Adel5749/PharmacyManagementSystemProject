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
using System.IO;

namespace CanadaPharmacyManagementSystem.PL
{
    public partial class FrmAddProduct : Form
    {
        Product product = new Product();
        Category category = new Category();
        ScientificName scientific = new ScientificName();
        ActiveMaterial active = new ActiveMaterial();
        FrmBusiness frmBusiness = new FrmBusiness();

        public FrmAddProduct()
        {
            InitializeComponent();
            cmbCategroyName.DataSource = category.CategorySearch("");
            cmbCategroyName.ValueMember = "CatID";
            cmbCategroyName.DisplayMember = "CatName";

            cmbActiveMaterial.DataSource = active.ActiveMaterialSearch("");
            cmbActiveMaterial.ValueMember = "AM_ID";
            cmbActiveMaterial.DisplayMember = "AM_Name";

            cmbScientificName.DataSource = scientific.ScientificNameSearch("");
            cmbScientificName.ValueMember = "Sn_ID";
            cmbScientificName.DisplayMember = "Sn_Name";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files|*.jpg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picProdImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbCategroyName.SelectedIndex == -1 || txtProdName.Text==string.Empty||txtSellPrice.Text==string.Empty||
                txtPuchasePrice.Text==string.Empty)
            {
                MessageBox.Show("Choose the important fields","Caution",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            DataTable dt = product.ProductVerifyName(-1, txtProdName.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This name exists already");
                return;
            }

            MemoryStream ms = new MemoryStream();
            picProdImage.Image.Save(ms,picProdImage.Image.RawFormat);
            byte[] img = ms.ToArray();

            product.ProductAdd(txtProdName.Text,txtProdDesc.Text,img,txtPuchasePrice.Text,txtSellPrice.Text,
                               Convert.ToInt16( cmbCategroyName.SelectedValue),Convert.ToInt16(cmbActiveMaterial.SelectedValue),
                               Convert.ToInt16( cmbScientificName.SelectedValue),txtBarcode.Text);

            MessageBox.Show("Added Successfully");

            frmBusiness.ClearTextBoxes(this.Controls);

        }
    }
}

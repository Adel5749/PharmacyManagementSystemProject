using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanadaPharmacyManagementSystem.PL
{
    class FrmBusiness
    {
        public void ClearTextBoxes(Control.ControlCollection controls   )
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    TextBox ctrl = (TextBox)control;
                    ctrl.Clear();
                }

                if (control is ComboBox)
                {
                    ComboBox cmb = (ComboBox)control;
                    cmb.Text="";
                }

                if (control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;
                    foreach (Control tinyCtrl in groupBox.Controls)
                    {
                        if (tinyCtrl is TextBox)
                        {
                            TextBox txtBox = (TextBox)tinyCtrl;
                            txtBox.Clear();
                        }

                        if (control is ComboBox)
                        {
                            ComboBox cmb = (ComboBox)control;
                            cmb.Text = "";
                        }
                    }
                }
            }
        }
    }
}

using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellerMainForm
{
    public partial class SellerUI : MaterialForm
    {
        public SellerUI()
        {
            InitializeComponent();
        }






        private void SellerUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            var startForm = Application.OpenForms[0];
            startForm.Show();
        }
    }
}

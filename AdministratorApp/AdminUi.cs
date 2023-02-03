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

namespace AdministratorApp
{
    public partial class AdminUi : MaterialForm
    {
        public AdminUi()
        {
            InitializeComponent();
        }

        //Переход к окну уведомлений
        private void noticeButton_Click(object sender, EventArgs e)
        {
            var noticeForm=new NoticeForm();
            noticeForm.Show();
            Hide();
        }
    }
}

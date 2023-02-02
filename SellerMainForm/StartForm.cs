using FoodStoreeDB.AppDb;
using MaterialSkin;
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
    public partial class StartForm : MaterialForm
    {
        AppDbContext db;
        public StartForm()
        {
            InitializeComponent();
            DesignActive();
            db = new AppDbContext();
            timer1.Start();
        }

        //Настройки дизайна
        private void DesignActive()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.Cyan900, Primary.Cyan900, Accent.DeepOrange700, TextShade.WHITE);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Вывод даты и времени
        private void timer1_Tick(object sender, EventArgs e)
        {
            string actualTime = DateTime.Now.ToString();
            materialLabel1.Text = actualTime;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Переход к окну продаж
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            SellerUI sellerUI = new SellerUI();
            Shift shift = new Shift();
            shift.Name = "Открытие смены";
            shift.WorkingShift = DateTime.Now;
            db.Shifts.Add(shift);
            db.SaveChanges();
            sellerUI.Show();
            Hide();
        }
    }
}

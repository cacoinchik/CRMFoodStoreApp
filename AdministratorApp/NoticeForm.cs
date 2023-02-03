using FoodStoreeDB.AppDb;
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
    public partial class NoticeForm : MaterialForm
    {
        AppDbContext db;
        public NoticeForm()
        {
            InitializeComponent();
            db=new AppDbContext();
            Shift lastShiftOpen=new Shift();
            lastShiftOpen = db.Shifts.OrderByDescending(x=>x.Id).FirstOrDefault();
            materialLabel1.Text=lastShiftOpen.WorkingShift.ToString();
        }
    }
}

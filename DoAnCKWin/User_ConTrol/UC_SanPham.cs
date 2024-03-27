using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCKWin.User_ConTrol
{
    public partial class UC_SanPham : UserControl
    {
        public UC_SanPham()
        {
            InitializeComponent();
            btn_Xemay.PerformClick();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Xemay.Controls.Clear();
            panel_Xemay.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_XeMay uC_XeMay = new UC_XeMay();
            addUserControl(uC_XeMay);
        }

        private void btn_PhuTung_Click(object sender, EventArgs e)
        {
            UC_PhuTung uC_PhuTung = new UC_PhuTung();
            addUserControl(uC_PhuTung);
        }
    }
}

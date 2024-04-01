using DoAnCKWin.User_ConTrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCKWin
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
           btnSanPham.PerformClick();

        }


        private void addUserControl(UserControl userControl)
            
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_SanPham uC_SanPham = new UC_SanPham();
            addUserControl(uC_SanPham );
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_KhachHang uC_KhachHang = new UC_KhachHang();
            addUserControl(uC_KhachHang );
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}

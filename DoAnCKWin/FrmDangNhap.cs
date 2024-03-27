using DoAnCKWin.DAO;
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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        
        bool KtraDangNhap(string taikhoan, string matkhau)
        {
            return TaiKhoanDAO.Instance.KtraDangNhap(taikhoan, matkhau);
        }
       
        //------
      
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "admin")
            {
                lberror.Visible = false;
                FormLoad formLoad = new FormLoad();
                formLoad.Show();
                this.Hide();
            }
            else
            {
                lberror.Visible = true;
                txtMatKhau.Focus();
            }
            /*if (KtraDangNhap(txtTaiKhoan.Text, txtTaiKhoan.Text))
            {
                lberror.Visible = false;
                ShareVar.tk = TaiKhoanDAO.Instance.LayTaiKhoan(txtTaiKhoan.Text, txtTaiKhoan.Text);
                FormLoad f = new FormLoad();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                lberror.Visible = true;
                txtMatKhau.Focus();
            }*/
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtTaiKhoan.Focus();
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnDangNhap.Focus();
        }

        private void btnDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                FrmMain f = new FrmMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void phide_Click_1(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '•')
            {
                peye.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void peye_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                phide.BringToFront();
                txtMatKhau.PasswordChar = '•';
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

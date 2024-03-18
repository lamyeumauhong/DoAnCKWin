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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KtraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                ShareVar.tk = TaiKhoanDAO.Instance.LayTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text);
                FrmBanHang f = new FrmBanHang();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        bool KtraDangNhap(string taikhoan, string matkhau)
        {
            return TaiKhoanDAO.Instance.KtraDangNhap(taikhoan, matkhau);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult tl = MessageBox.Show(" Bạn có chắc muốn thoát!", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (tl != DialogResult.Yes)
                e.Cancel = true;
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtMatKhau.Focus();
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

        private void btnHienMk_Click(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !txtMatKhau.UseSystemPasswordChar;
        }
    }
}

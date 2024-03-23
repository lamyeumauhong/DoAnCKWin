using DoAnCKWin.DTO;
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
using System.Globalization;

namespace DoAnCKWin
{
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent();
            LoadLoaiHang();
            LoadMANV();
        }
        void LoadHang(string tenhang)
        {
            cbHangHoa.DataSource = HangHoaDAO.Instance.LoadHangHoaCombobox(tenhang);
            cbHangHoa.DisplayMember = "TenHang";
        }
        void LoadLoaiHang()
        {
            cbLoaiHang.DataSource = LoaiHangDAO.Instance.LayDsLoaiHang();
            cbLoaiHang.DisplayMember = "TenLoaiHang";
        }
        private void cbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenhang;
            LoaiHangDTO selected = cbLoaiHang.SelectedItem as LoaiHangDTO;
            tenhang = selected.Tenloaihang;
            LoadHang(tenhang);
        }
        List<ThongTinHoaDon> list = new List<ThongTinHoaDon>();
        float TongTien;
        private int flag = 0;
        bool KtraAdmin(TaiKhoanDTO tk)
        {
            return TaiKhoanDAO.Instance.KtraAdmin(tk);
        }
        ThongTinHoaDon ConvertBillInfo()
        {
            ThongTinHoaDon tthd = new ThongTinHoaDon();

            ListViewItem item = listViewHoaDon.FocusedItem;
            tthd.Mahang = Convert.ToInt32(item.SubItems[0].Text);
            tthd.Tenhang = item.SubItems[1].Text;
            tthd.Gia = (float)Convert.ToDouble(item.SubItems[2].Text);
            tthd.Soluong = (float)Convert.ToDouble(item.SubItems[3].Text);
            tthd.Thanhtien = (float)Convert.ToDouble(item.SubItems[4].Text);
            return tthd;
        }
        void TinhTongTien()
        {
            TongTien = 0;
            foreach (ThongTinHoaDon tthd in list)
            {
                TongTien += tthd.Thanhtien;
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtThanhTien.Text = TongTien.ToString("c", culture);
        }
        void LoadMANV()
        {
            txtMaNV.Text = ShareVar.tk.Manv.ToString();
        }
        void updateTongTienKH()
        {
            
        }
        void InHoaDon()
        {
          
        }
        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            listViewHoaDon.Items.Clear();
            list.Clear();
            TinhTongTien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThongTinHoaDon tthd = new ThongTinHoaDon();

            ListViewItem item = listViewHoaDon.FocusedItem;
            if (item == null)
            {
                MessageBox.Show("Chưa chọn thông tin nào", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            tthd = ConvertBillInfo();
            listViewHoaDon.Items.Remove(item);
            foreach (ThongTinHoaDon tt in list)
            {
                if (tt.Mahang == tthd.Mahang &&
                    tt.Tenhang == tthd.Tenhang &&
                    tt.Gia == tthd.Gia &&
                    tt.Soluong == tthd.Soluong &&
                    tt.Thanhtien == tthd.Thanhtien)
                {
                    list.Remove(tt);
                    break;
                }
            }
            TinhTongTien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HangHoaDTO hanghoa = cbHangHoa.SelectedItem as HangHoaDTO;
            if (hanghoa.Soluongconkho == 0)
            {
                MessageBox.Show("Hàng trong kho đã hết!", "Thông báo");
                return;
            }
            float sl = (float)Convert.ToDouble(txtSoluong.Text.Trim());
            if (sl < 0)
            {
                MessageBox.Show("Số lượng không thể âm", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ThongTinHoaDon tthd = new ThongTinHoaDon();
            HangHoaDTO hh = new HangHoaDTO();
            hh = cbHangHoa.SelectedItem as HangHoaDTO;
            tthd.Mahang = hh.Mahang;
            tthd.Tenhang = hh.Tenhang;
            tthd.Gia = hh.GiaKM;
            tthd.Soluong = sl;
            tthd.Thanhtien = tthd.Gia * tthd.Soluong;
            list.Add(tthd);
            ListViewItem newItem = new ListViewItem(tthd.Mahang.ToString());
            newItem.SubItems.Add(tthd.Tenhang.ToString());
            newItem.SubItems.Add(tthd.Gia.ToString());
            newItem.SubItems.Add(tthd.Soluong.ToString());
            newItem.SubItems.Add(tthd.Thanhtien.ToString());
            listViewHoaDon.Items.Add(newItem);
            TinhTongTien();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                InHoaDon();
            else
            {
                MessageBox.Show("Chưa thanh toán!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void FrmBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult tl =
            MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl != DialogResult.OK)
                e.Cancel = true;
        }
       
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KtraAdmin(ShareVar.tk))
            {
                FrmMain f = new FrmMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Chỉ quản lí mới vào được", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

    }
}

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
        List<ThongTinHoaDon> list = new List<ThongTinHoaDon>();
        float TongTien;
        private int flag = 0;
        void LoadHang(string tenhang)
        {
            List<HangHoaDTO> danhSachHangHoa = HangHoaDAO.Instance.LoadHangHoaCombobox(tenhang);
            cbHangHoa.DataSource = danhSachHangHoa;
            cbHangHoa.DisplayMember = "Tenhang";
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
            float tongTien = 0;
            foreach (ListViewItem item in listViewHoaDon.Items)
            {
                float thanhTien = float.Parse(item.SubItems[4].Text);
                tongTien += thanhTien;
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtThanhTien.Text = tongTien.ToString("c", culture);

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
            ppdHoaDon.Document = pDHoaDon;
            ppdHoaDon.ShowDialog();
        }
        private void ThemSanPhamVaoListView(ThongTinHoaDon sanPham)
        {
            foreach (ListViewItem item in listViewHoaDon.Items)
            {
                if (item.SubItems[0].Text == sanPham.Mahang.ToString())
                {
                    // Sản phẩm đã tồn tại trong danh sách, cập nhật số lượng và thành tiền
                    float soLuongMoi = float.Parse(item.SubItems[3].Text) + sanPham.Soluong;
                    item.SubItems[3].Text = soLuongMoi.ToString();
                    float thanhTienMoi = float.Parse(item.SubItems[4].Text) + (sanPham.Gia * sanPham.Soluong);
                    item.SubItems[4].Text = thanhTienMoi.ToString();
                    TinhTongTien();
                    return;
                }
            }

            // Nếu sản phẩm chưa tồn tại trong danh sách, thêm mới vào listViewHoaDon
            ListViewItem newItem = new ListViewItem(sanPham.Mahang.ToString());
            newItem.SubItems.Add(sanPham.Tenhang);
            newItem.SubItems.Add(sanPham.Gia.ToString());
            newItem.SubItems.Add(sanPham.Soluong.ToString());
            newItem.SubItems.Add(sanPham.Thanhtien.ToString());
            listViewHoaDon.Items.Add(newItem);
            TinhTongTien();
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
            HangHoaDTO hh = cbHangHoa.SelectedItem as HangHoaDTO;
            tthd.Mahang = hh.Mahang;
            tthd.Tenhang = hh.Tenhang;
            tthd.Gia = hh.GiaKM;
            tthd.Soluong = sl;
            tthd.Thanhtien = tthd.Gia * tthd.Soluong;

            // Thêm sản phẩm vào danh sách hoặc cập nhật số lượng nếu sản phẩm đã tồn tại
            ThemSanPhamVaoListView(tthd);

            // Cập nhật giá trị của txtTongTien
            TinhTongTien();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (list.Count() == 0)
            {
                MessageBox.Show("Hóa Đơn chưa có mặt hàng nào!", "Thông báo");
                return;
            }
           /* foreach (ThongTinHoaDon tt in list)
            {
                int soLuongTonKho = HangHoaDAO.Instance.Soluongconkho(tt.Mahang);
                if (tt.Soluong > soLuongTonKho)
                {
                    MessageBox.Show($"Số lượng tồn kho không đủ cho sản phẩm {tt.Tenhang}!", "Thông báo");
                    return;
                }
            }*/
            int manv = Convert.ToInt32(txtMaNV.Text.Trim());
            HoaDonDAO.Instance.InsertBill(manv);
            int mahd = HoaDonDAO.Instance.LayIDMax();
            foreach (ThongTinHoaDon tt in list)
            {
                BanHangDAO.Instance.InsertBillInfo(mahd, tt.Mahang, tt.Soluong);
                HangHoaDAO.Instance.CapNhatLuongHang(tt.Mahang, tt.Soluong);
            }
            flag = 1;
            HoaDonDAO.Instance.UpdateTongBill(mahd, TongTien);

            MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK);
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


        private void pDHoaDon_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var w = pDHoaDon.DefaultPageSettings.PaperSize.Width;
            e.Graphics.DrawString("Cửa hàng xe máy ",
                new Font("Times New Roman", 16, FontStyle.Bold),
                Brushes.Black, new Point(100, 20));
            e.Graphics.DrawString(
                string.Format("Mã hóa đơn:{0}", HoaDonDAO.Instance.LayIDMax()),
                new Font("Times New Roman", 12, FontStyle.Bold),
                Brushes.Black, new Point(w / 2 + 100, 20)
                );
            e.Graphics.DrawString(
               string.Format("{0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")),
               new Font("Times New Roman", 12, FontStyle.Bold),
               Brushes.Black, new Point(w / 2 + 100, 70)
               );
            e.Graphics.DrawString(
              string.Format("Nhân viên thanh toán:{0}", NhanVienDAO.Instance.LayTTNV(ShareVar.tk.Manv).Rows[0]["TenNV"]),
              new Font("Times New Roman", 12, FontStyle.Bold),
              Brushes.Black, new Point(w / 2 + 100, 100)
              );
            Pen blackpen = new Pen(Color.Black, 1);
            var y = 120;
            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackpen, p1, p2);
            y += 20;
            e.Graphics.DrawString("Mã hàng",
                new Font("Times New Roman", 11, FontStyle.Bold),
                Brushes.Black,
                new Point(10, y)
                );
            e.Graphics.DrawString("Tên hàng",
               new Font("Times New Roman", 11, FontStyle.Bold),
               Brushes.Black,
               new Point(170, y)
               );
            e.Graphics.DrawString("Giá",
               new Font("Times New Roman", 11, FontStyle.Bold),
               Brushes.Black,
               new Point(w / 2 - 70, y)
               );
            e.Graphics.DrawString("Số lượng",
               new Font("Times New Roman", 11, FontStyle.Bold),
               Brushes.Black,
               new Point(w / 2 + 100, y)
               );
            e.Graphics.DrawString("Thành tiền",
              new Font("Times New Roman", 11, FontStyle.Bold),
              Brushes.Black,
              new Point(w - 200, y)
              );
            y += 30;
            foreach (ThongTinHoaDon tt in list)
            {
                e.Graphics.DrawString(
                string.Format("{0}", tt.Mahang.ToString()),
                new Font("Times New Roman", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(10, y)
                );
                e.Graphics.DrawString(
               string.Format("{0}", tt.Tenhang.ToString()),
               new Font("Times New Roman", 12, FontStyle.Bold),
               Brushes.Black,
               new Point(170, y)
               );
                e.Graphics.DrawString(
              string.Format("{0}", tt.Gia.ToString()),
              new Font("Times New Roman", 12, FontStyle.Bold),
              Brushes.Black,
              new Point(w / 2 - 70, y)
              );
                e.Graphics.DrawString(
             string.Format("{0}", tt.Soluong.ToString()),
             new Font("Times New Roman", 12, FontStyle.Bold),
             Brushes.Black,
             new Point(w / 2 + 100, y)
             );
                e.Graphics.DrawString(
             string.Format("{0}", tt.Thanhtien.ToString()),
             new Font("Times New Roman", 12, FontStyle.Bold),
             Brushes.Black,
             new Point(w - 200, y)
             );

                y += 30;
            }
            y += 40;
            Point p3 = new Point(10, y);
            Point p4 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackpen, p3, p4);
            y += 30;
            e.Graphics.DrawString(
             string.Format("Tổng tiền:{0}", txtThanhTien.Text.Trim()),
             new Font("Times New Roman", 14, FontStyle.Bold),
             Brushes.Black,
             new Point(w - 250, y)
             );
            y += 70;
            Point p5 = new Point(10, y);
            Point p6 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackpen, p5, p6);
        }

        
    }
}

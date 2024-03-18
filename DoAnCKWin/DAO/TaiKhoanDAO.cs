using DoAnCKWin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKWin.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private TaiKhoanDAO() { }
        public TaiKhoanDTO LayTaiKhoan(string TaiKhoan, string MatKhau)
        {
            string query = "select * from TaiKhoan where tendangnhap='" + TaiKhoan + "' and Matkhau='" + MatKhau + "'";
            DataTable data = DataProvider.Instance.MyExcuteQuery(query);
            DataRow row = data.Rows[0];
            TaiKhoanDTO tk = new TaiKhoanDTO(row);
            return tk;
        }
        public DataTable LoadTaiKhoan()
        {
            string query = "select * from TaiKhoan";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.MyExcuteQuery(query);
            return dt;
        }
        public bool KtraDangNhap(string TaiKhoan, string MatKhau)
        {
            bool f = false;
            string query = "select * from TaiKhoan where tendangnhap='" + TaiKhoan + "' and Matkhau='" + MatKhau + "'";
            DataTable data = DataProvider.Instance.MyExcuteQuery(query);
            if (data.Rows.Count == 1)
                f = true;
            return f;
        }
        public bool KtraAdmin(TaiKhoanDTO tk)
        {
            bool f = false;
            if (tk.LoaiTK == 0)
                f = true;
            return f;
        }
        public bool ThemTaiKhoan(string tendangnhap, string tenhienthi, string matkhau, int loaitaikhoan, int maNV)
        {
            bool f = false;
            string query = "insert into TaiKhoan values('" + tendangnhap + "',N'" + tenhienthi + "','" + matkhau + "'," + loaitaikhoan + "," + maNV + ")";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public bool XoaTaiKhoan(string tendangnhap, string matkhau)
        {
            bool f = false;
            string query = "delete TaiKhoan where tendangnhap='" + tendangnhap + "' and matkhau='" + matkhau + "'";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public bool DoiMatKhau(int matk, string matkhaumoi)
        {
            bool f = false;
            string query = "update TaiKhoan set Matkhau=N'" + matkhaumoi + "' where matk=" + matk + " ";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
    }
}
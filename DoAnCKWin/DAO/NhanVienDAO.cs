using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKWin.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private NhanVienDAO() { }
        public DataTable LoadNhanVien()
        {
            string query = "select * from NhanVien";
            DataTable data = new DataTable();
            data = DataProvider.Instance.MyExcuteQuery(query);
            return data;
        }
        public DataTable LayTTNV(int manv)
        {
            string query = "select * from NhanVien,TaiKhoan where NhanVien.MaNV=TaiKhoan.MaNV and NhanVien.MaNV=" + manv + "";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.MyExcuteQuery(query);
            return dt;
        }
    }
}

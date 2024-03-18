using DoAnCKWin.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKWin.DTO
{
    public class BanHangDTO
    {
        private int mahd;
        private int mahang;
        private float soluong;

        public int Mahd { get => mahd; set => mahd = value; }
        public int Mahang { get => mahang; set => mahang = value; }
        public float Soluong { get => soluong; set => soluong = value; }
        public BanHangDTO() { }
        public BanHangDTO(int mahd, int mahang, float sl)
        {
            this.Mahang = mahang;
            this.Mahd = mahd;
            this.Soluong = sl;
        }
        public BanHangDTO(DataRow r)
        {
            this.Mahd = (int)r["MaHoaDon"];
            this.Mahang = (int)r["MaHang"];
            this.Soluong = (float)Convert.ToDouble(r["soluong"]);
        }
        public bool XoaHangKhoiBill(int mahd, int mahang)
        {
            bool f = false;
            string query = "delete from BanHang where MaHoaDon=" + mahd + " and MaHang=" + mahang + "";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
    }
}

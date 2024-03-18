using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKWin.DTO
{
    public class ThongTinHoaDon
    {
        private int mahang;
        private string tenhang;
        private float gia;
        private float soluong;
        private float thanhtien;

        public int Mahang { get => mahang; set => mahang = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public float Gia { get => gia; set => gia = value; }
        public float Soluong { get => soluong; set => soluong = value; }
        public float Thanhtien { get => thanhtien; set => thanhtien = value; }
        public ThongTinHoaDon() { }
        public ThongTinHoaDon(int mahang, string tenhang, float gia, float soluong, float thanhtien = 0)
        {
            this.Mahang = mahang;
            this.Tenhang = tenhang;
            this.Gia = gia;
            this.soluong = soluong;
            this.thanhtien = thanhtien;
        }
        public ThongTinHoaDon(DataRow row)
        {
            this.Mahang = (int)row["MaHang"];
            this.Tenhang = row["TenHang"].ToString();
            this.Gia = (float)Convert.ToDouble(row["GiaKM"]);
            this.Soluong = (float)Convert.ToDouble(row["soluong"]);
            this.Thanhtien = (float)Convert.ToDouble(row["Thanhtien"]);
        }
    }
}
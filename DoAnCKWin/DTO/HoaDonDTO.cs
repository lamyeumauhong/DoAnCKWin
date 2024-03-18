using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKWin.DTO
{
    public class HoaDonDTO
    {
        private int mahd;

        private int manv;
        private DateTime ngay;
        private float tongtien;
        public int Mahd { get => mahd; set => mahd = value; }
        public int Manv { get => manv; set => manv = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public float Tongtien { get => tongtien; set => tongtien = value; }

        public HoaDonDTO() { }
        public HoaDonDTO(int mahd, int manv, DateTime ngay, float tongbill)
        {
            this.Mahd = mahd;
            this.Manv = manv;
            this.Ngay = ngay;
            this.Tongtien = tongbill;
        }
        public HoaDonDTO(DataRow r)
        {
            this.Mahd = (int)r["MaHoaDon"];
            this.Manv = (int)r["MaNV"];
            this.Ngay = (DateTime)r["Ngay"];
            this.Tongtien = (float)Convert.ToDouble(r["tongbill"]);
        }
    }
}

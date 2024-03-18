using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKWin.DTO
{
    public class HangHoaDTO
    {
        private int mahang;
        private string tenhang;
        private float gia;
        private float giaKM;
        private float soluongconkho;
        private int loaihang;
        private int nhaCC;
        public int Mahang { get => mahang; set => mahang = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public float Gia { get => gia; set => gia = value; }
        public int Loaihang { get => loaihang; set => loaihang = value; }
        public int NhaCC { get => nhaCC; set => nhaCC = value; }
        public float GiaKM { get => giaKM; set => giaKM = value; }
        public float Soluongconkho { get => soluongconkho; set => soluongconkho = value; }


        public HangHoaDTO(int mahang, string tenhang, float gia, float giaKM, float slck, int loaihang, int nhaCC)
        {
            this.Mahang = mahang;
            this.Tenhang = tenhang;
            this.Gia = gia;
            this.GiaKM = giaKM;
            this.Soluongconkho = slck;
            this.Loaihang = loaihang;
            this.NhaCC = nhaCC;
        }
        public HangHoaDTO(DataRow r)
        {
            this.Mahang = (int)r["MaHang"];
            this.Tenhang = r["TenHang"].ToString();
            this.Gia = (float)Convert.ToDouble(r["Gia"]);
            this.GiaKM = (float)Convert.ToDouble(r["GiaKM"]);
            this.Soluongconkho = (float)Convert.ToDouble(r["Soluongconkho"]);
            this.Loaihang = (int)r["LoaiHang"];
            this.NhaCC = (int)r["NhaCC"];
        }
        public HangHoaDTO() { }
    }
}

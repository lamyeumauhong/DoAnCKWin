using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKWin.DTO
{
    public class TaiKhoanDTO
    {
        private int matk;
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Tenhienthi { get => tenhienthi; set => tenhienthi = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int LoaiTK { get => loaiTK; set => loaiTK = value; }
        public int Manv { get => manv; set => manv = value; }
        public int Matk { get => matk; set => matk = value; }

        private string tendangnhap;
        private string tenhienthi;
        private string matkhau;
        private int loaiTK;
        private int manv;
        public TaiKhoanDTO(int matk, string tendangnhap, string tenhienthi, string matkhau, int loaiTK, int manv)
        {
            this.Matk = matk;
            this.tendangnhap = tendangnhap;
            this.tenhienthi = tenhienthi;
            this.matkhau = matkhau;
            this.loaiTK = loaiTK;
            this.Manv = manv;
        }
        public TaiKhoanDTO() { }

        public TaiKhoanDTO(DataRow row)
        {
            this.Matk = (int)row["matk"];
            this.tendangnhap = row["tendangnhap"].ToString();
            this.tenhienthi = row["tenhienthi"].ToString();
            this.matkhau = row["Matkhau"].ToString();
            this.loaiTK = (int)row["LoaiTK"];
            this.Manv = (int)row["MaNV"];
        }
    }
}

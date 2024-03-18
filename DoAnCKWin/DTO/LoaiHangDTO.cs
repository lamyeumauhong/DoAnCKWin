using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKWin.DTO
{
    public class LoaiHangDTO
    {
        private string tenloaihang;
        private int maloaihang;

        public string Tenloaihang { get => tenloaihang; set => tenloaihang = value; }
        public int Maloaihang { get => maloaihang; set => maloaihang = value; }

        public LoaiHangDTO(int maloaihang, string tenloaihang)
        {
            this.Maloaihang = maloaihang;
            this.Tenloaihang = tenloaihang;
        }
        public LoaiHangDTO(DataRow row)
        {
            this.Maloaihang = (int)row["MaLoaiHang"];
            this.Tenloaihang = row["TenLoaiHang"].ToString();
        }
    }
}

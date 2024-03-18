using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKWin.DTO
{
    public class NhaCungCapDTO
    {
        private int mancc;
        private string tenncc;
        private string diachi;
        private string sdt;

        public int Mancc { get => mancc; set => mancc = value; }
        public string Tenncc { get => tenncc; set => tenncc = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public NhaCungCapDTO() { }
        public NhaCungCapDTO(int mancc, string tenncc, string diachi, string sdt)
        {
            this.Mancc = mancc;
            this.tenncc = tenncc;
            this.Diachi = diachi;
            this.Sdt = sdt;
        }
        public NhaCungCapDTO(DataRow row)
        {
            this.Mancc = (int)row["MaNCC"];
            this.Tenncc = row["TenNCC"].ToString();
            this.Diachi = row["DiaChi"].ToString();
            this.Sdt = row["Sdt"].ToString();
        }
    }
}

using DoAnCKWin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKWin.DAO
{
    public class HangHoaDAO
    {
        private static HangHoaDAO instance;
        public static HangHoaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HangHoaDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private HangHoaDAO() { }
        public bool UpdateGia()
        {
            bool f = false;
            string query = "update HangHoa set HangHoa.GiaKM=Gia-Gia*KhuyenMai.MucGiam/100 from HangHoa inner join KhuyenMai on HangHoa.MaHang = KhuyenMai.MaHang where KhuyenMai.NgayHetHan >= GETDATE()";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public bool UpdateGia2(int mahang)
        {
            bool f = false;
            string query = "update HangHoa set GiaKM=Gia where MaHang=" + mahang + "";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public DataTable LoadHangHoa()
        {
            UpdateGia();
            string query = "select MaHang,TenHang,Gia,GiaKM,Soluongconkho,TenLoaiHang,TenNCC from HangHoa,LoaiHang,NhaCungCap where HangHoa.LoaiHang = LoaiHang.MaLoaiHang and HangHoa.NhaCC = NhaCungCap.MaNCC";
            DataTable data = new DataTable();
            data = DataProvider.Instance.MyExcuteQuery(query);
            return data;
        }
        public List<HangHoaDTO> LoadHangHoaCombobox(string loaihang)
        {
            UpdateGia();
            List<HangHoaDTO> list = new List<HangHoaDTO>();
            string query = " select MaHang,TenHang,Gia,GiaKM,Soluongconkho,LoaiHang,NhaCC from HangHoa,LoaiHang where HangHoa.LoaiHang=LoaiHang.MaLoaiHang and LoaiHang.TenLoaiHang=N'" + loaihang + "'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.MyExcuteQuery(query);
            foreach (DataRow r in data.Rows)
            {
                HangHoaDTO hh = new HangHoaDTO(r);
                list.Add(hh);
            }
            return list;
        }

        public bool CapNhatLuongHang(int mahang, float sl)
        {
            bool f = false;
            string query = "update HangHoa set Soluongconkho=Soluongconkho-(" + sl + ") where MaHang=" + mahang + "";
            string query2 = "update HangHoa set Soluongconkho=0 where MaHang=" + mahang + " and Soluongconkho<0 ";
            DataProvider.Instance.MyExcuteNonQuery(query);
            f = DataProvider.Instance.MyExcuteNonQuery(query2);
            return f;
        }
        public bool ThemHangHoa(int loaihang, string tenhang, float giaban, int NCC)
        {
            bool f = false;
            string query = "insert into HangHoa values(N'" + tenhang + "'," + giaban + ",null,default," + loaihang + "," + NCC + ")";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            UpdateGia();
            return f;
        }
        public bool SuaHangHoa(int mahang, string tenhang, float giaban, int ncc)
        {
            bool f = false;
            string query = "update HangHoa set TenHang=N'" + tenhang + "',Gia=" + giaban + ",NhaCC=" + ncc + " where MaHang= " + mahang + "";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public bool XoaHangHoa(int mahang)
        {
            bool f = false;
            string query = "delete from HangHoa where MaHang=" + mahang + "";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public DataTable TimKiemTenGanDung(string name)
        {
            DataTable dt = new DataTable();
            string query = "select HangHoa.MaHang,HangHoa.TenHang,Gia,GiaKM,Soluongconkho,TenLoaiHang,TenNCC from HangHoa,LoaiHang,NhaCungCap where HangHoa.LoaiHang = LoaiHang.MaLoaiHang and HangHoa.NhaCC = NhaCungCap.MaNCC and dbo.fuConvertToUnsign1(HangHoa.TenHang) like dbo.fuConvertToUnsign1(N'%" + name + "%')";
            dt = DataProvider.Instance.MyExcuteQuery(query);
            return dt;
        }
        public int LayidMax()
        {
            int i = 0;
            string query = "select max(MaHang) from HangHoa";
            i = (int)DataProvider.Instance.MyExcuteScalar(query);
            return i;
        }
    }
}

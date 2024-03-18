using DoAnCKWin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKWin.DAO
{
    public class LoaiHangDAO
    {
        private static LoaiHangDAO instance;
        public static LoaiHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiHangDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private LoaiHangDAO() { }
        public List<LoaiHangDTO> LayDsLoaiHang()
        {
            List<LoaiHangDTO> listLoaiHang = new List<LoaiHangDTO>();
            string query = "select * from LoaiHang";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.MyExcuteQuery(query);
            foreach (DataRow r in dt.Rows)
            {
                LoaiHangDTO lh = new LoaiHangDTO(r);
                listLoaiHang.Add(lh);
            }

            return listLoaiHang;
        }

    }
}

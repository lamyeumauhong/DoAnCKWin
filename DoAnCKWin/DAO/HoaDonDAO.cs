using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKWin.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private HoaDonDAO() { }
        public bool InsertBill(int manv)
        {
            bool f = false;
            string query = "insert into HoaDon values(" + manv + ",default,default)";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }

        public int LayIDMax()
        {
            int i = 0;
            string query = "select max(MaHoaDon) from HoaDon";
            try
            {
                i = (int)DataProvider.Instance.MyExcuteScalar(query);
            }
            catch
            {

            }
            return i;
        }
        public bool UpdateTongBill(int mahd, float tien)
        {
            bool f = false;
            string query = "update HoaDon set tongbill = COALESCE(tongbill, 0) + " + tien + " where MaHoaDon = " + mahd;
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }

    }
}

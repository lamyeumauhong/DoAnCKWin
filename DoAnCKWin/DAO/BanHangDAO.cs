using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKWin.DAO
{
    public class BanHangDAO
    {
        private static BanHangDAO instance;
        public static BanHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BanHangDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BanHangDAO() { }
        public bool InsertBillInfo(int mahd, int mahang, float sl)
        {
            string query = "insert into BanHang values(" + mahd + "," + mahang + "," + sl + ")";
            bool f = false;
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
    }
}

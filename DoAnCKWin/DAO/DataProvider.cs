using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKWin.DAO
{
    public class DataProvider
    {
        private string cnnstr = "Data Source=.;Initial Catalog=QLXE;User ID=sa;Password=123";
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private DataProvider() { }

        public DataTable MyExcuteQuery(string query, params SqlParameter[] p)
        {
            DataTable data = new DataTable();
            SqlConnection conn = new SqlConnection(cnnstr);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            foreach (SqlParameter item in p)
                cmd.Parameters.Add(item);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(data);
            conn.Close();
            return data;
        }
        public bool MyExcuteNonQuery(string query, params SqlParameter[] p)
        {
            bool f = false;
            SqlConnection conn = new SqlConnection(cnnstr);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Clear();
            foreach (SqlParameter item in p)
                cmd.Parameters.Add(item);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;

            }
            catch (SqlException)
            {
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public object MyExcuteScalar(string query, params SqlParameter[] p)
        {
            object data = 0;
            SqlConnection conn = new SqlConnection(cnnstr);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Clear();
            foreach (SqlParameter item in p)
                cmd.Parameters.Add(item);
            try
            {
                data = cmd.ExecuteScalar();
            }
            catch (SqlException)
            {
            }
            finally
            {
                conn.Close();
            }
            return data;
        }
    }
}

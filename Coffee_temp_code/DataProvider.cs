using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCaPheDAO
{
    public static class DataProvider
    {
        static string strChuoiKetNoi = "Data Source=localhost;Initial Catalog=CuaHangCoffee;Integrated Security=True;";
        
        public static SqlConnection TaoKetNoi()
        {
            SqlConnection conn = new SqlConnection(strChuoiKetNoi);
            conn.Open();
            return conn;
        }

        public static SqlDataReader TruyVan(string strTruyVan,SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strTruyVan, conn);
                SqlDataReader sdr = com.ExecuteReader();
                return sdr;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra!");
            }
        }
        public static SqlDataReader TruyVan(string strTruyVan, SqlParameter[] pars, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strTruyVan, conn);
                com.Parameters.AddRange(pars);
                SqlDataReader sdr = com.ExecuteReader();
                return sdr;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra!");
            }
        }

        public static bool ThucThi(string strLenh,SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strLenh, conn);
                int kq = com.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra!");
            }
        }
        public static bool ThucThi(string strLenh,SqlParameter[] pars, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strLenh, conn);
                com.Parameters.AddRange(pars);
                int kq = com.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCaPheDAO
{
    public class NhanVienDAO
    {
        public NhanVienDTO DangNhap(string username, string password)
        {
            try
            {
                NhanVienDTO nv = null;
                SqlConnection conn = DataProvider.TaoKetNoi();
                string str = "Select * From NhanVien Where MaNV=@mnv AND Password=@mk AND TrangThai=1";
                SqlParameter[] pas = new SqlParameter[2];
                pas[0] = new SqlParameter("mnv", username);
                pas[1] = new SqlParameter("mk", password);
                SqlDataReader sdr = DataProvider.TruyVan(str,pas, conn);
                if (sdr.Read())
                {
                    nv = new NhanVienDTO();
                    nv.MaNV = sdr["MaNV"].ToString();
                    nv.Ten = sdr["Ten"].ToString();
                    nv.Ho = sdr["Ho"].ToString();
                    nv.HinhAnh = sdr["HinhAnh"].ToString();
                    nv.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                    nv.Password = sdr["Password"].ToString();
                    nv.TrangThai = 1;
                }
                sdr.Close();
                conn.Close();
                return nv;
            }
            catch(Exception ex) 
            {
                return null;
            }
        }
    }
}
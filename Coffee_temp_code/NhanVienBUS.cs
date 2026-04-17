using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCaPheBUS
{
    public class NhanVienBUS
    {
        public NhanVienDTO DangNhap(string username, string password)
        {
            NhanVienDAO nvDAO = new NhanVienDAO();
            return nvDAO.DangNhap(username, password);
        }
    }
}
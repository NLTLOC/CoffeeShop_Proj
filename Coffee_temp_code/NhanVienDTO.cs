using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCaPheDTO
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string HinhAnh { get; set; }
        public string Password { get; set; }
        public string TrangThai { get; set; }
    }
}
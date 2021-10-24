using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    
    class BLLDangNhap
    {
        DAL dal = new DAL();
        public DataTable TaiKhoan(string tenDN, string MK)
        {
            string sql = "select * from ThuThu where tenDangNhap = '" + tenDN + "' and matKhau = '" + MK + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}

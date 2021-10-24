using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyThuVien
{
    class BLLNhanVien
    {
        DAL dal = new DAL();
        public DataTable ShowNhanVien()
        {
            string sql = "select * from NhanVien";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void InsertNhanVien(string maNV, string hoTenNV, string tenDangNhap, string matKhau , DateTime NgaySinh, string diaChi, string sdt, string quanLy)
        {
            string sql = "insert into NhanVien values('" + maNV + "', N'" + hoTenNV +
                         "', '" + tenDangNhap + "', '" + matKhau + "', '" + NgaySinh.ToString() + "', '" +
                         diaChi + "', '" + sdt + "', '" + quanLy + "')";
            dal.ExecNonQuery(sql);
        }
        public void UpdateNhanVien(string maNV, string hoTenNV, string tenDangNhap, string matKhau, DateTime NgaySinh, string diaChi, string sdt, string quanLy)
        {
            string sql = "Update NhanVien " +
                " set maNV = N'" + maNV + "', hoTenNV = N'" + hoTenNV + "', SDT = '" + sdt + "', tenDangNhap ='" + tenDangNhap + "', matKhau = '"+
                matKhau+ "', NgaySinh ='"+ NgaySinh.ToString() + "',diaChi = '"+ diaChi+ "',quanLy ='" + quanLy+
                "' where maNV = '" + maNV + "'";
            dal.ExecNonQuery(sql);
        }

        public void DeleteNhanVien(string maNV)
        {
            string sql = "delete NhanVien where maNV = '" + maNV + "'";
            dal.ExecNonQuery(sql);
        }
    }
}

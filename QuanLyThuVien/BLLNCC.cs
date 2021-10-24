using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    class BLLNCC
    {
        DAL dal = new DAL();
        public DataTable ShowNCC()
        {
            string sql = "select MaNCC, TenNCC, DiaChi, SDT " +
                         " from NhaCC";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void InsertNCC(string maNCC, string tenNCC, string diaChi, string sDT)
        {
            string sql = "insert into NhaCC values('" + maNCC + "', N'" + tenNCC +
                         "', N'" + diaChi + "', '" + sDT + "')";
            dal.ExecNonQuery(sql);
        }
        public void UpdateNCC(string maNCC, string tenNCC, string diaChi, string sDT)
        {
            string sql = "Update NhaCC " +
                " set TenNCC = N'" + tenNCC + "', DiaChi = N'" + diaChi + "', SDT = '" + sDT +
                "' where MaNCC = '" + maNCC + "'";
            dal.ExecNonQuery(sql);
        }
        public DataTable SearchProduct4(string maNCC)
        {
            string sql = "select MaHang, TenHang, MaNCC,LoaiHang, SoLuong, DonGiaXuat " +
                         " from HangHoa where MaNCC = '" + maNCC + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void DeleteNCC(string maNCC)
        {
            string sql = "delete NhaCC where MaNCC = '" + maNCC + "'";
            dal.ExecNonQuery(sql);
        }

        public DataTable SearchNCC(string maNCC)
        {
            string sql = "select MaNCC, TenNCC, DiaChi, SDT " +
                         " from NhaCC where MaNCC like N'%" + maNCC + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable SearchNCC1(string tenNCC)
        {
            string sql = "select MaNCC, TenNCC, DiaChi, SDT " +
                         " from NhaCC where TenNCC like N'%" + tenNCC + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable SearchNCC4(string DiaChi)
        {
            string sql = "select MaNCC, TenNCC, DiaChi, SDT " +
                         " from NhaCC where DiaChi like N'%" + DiaChi + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable SearchNCC3(string SDT)
        {
            string sql = "select MaNCC, TenNCC, DiaChi, SDT " +
                         " from NhaCC where SDT like N'%" + SDT + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}

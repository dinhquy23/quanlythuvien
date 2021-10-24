using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyThuVien
{
    class BLLNhapSach
    {
        DAL dal = new DAL();
        public DataTable ShowSach()
        {
            string sql = "select * from Sach";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public DataTable ShowMaSach()
        {
            string sql = "select maSach " +
                         " from Sach";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable ShowMaNCC()
        {
            string sql = "select MaNCC " +
                         " from NhaCC";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void InsertSach(string maSach, string tenSach, string tinhTrang, int soLuongNhap
                               , int gia, int namXB, string tacGia, string nhaXB, string maNCC,
                               string nguoiNhap)
        {
            string sql = "insert into Sach values('" + maSach + "', N'" + tenSach +
                         "', N'" + tinhTrang + "'," + soLuongNhap + ", " + gia + "," + namXB
                         + ", N'" + tacGia + "', N'" + nhaXB + "','"
                         + maNCC + "', '" + nguoiNhap + "')";

            dal.ExecNonQuery(sql);
        }

        public void UpdateSach(string maSach, int soLuongNhap)
        {

            string sql = "Update Sach set  soLuongNhap = soLuongNhap + " + soLuongNhap +
                " where maSach = '" + maSach + "'";
            dal.ExecNonQuery(sql);
        }
        public DataTable CheckNumSach(string masach)
        {
            string sql = "select * from Sach where maSach = '" + masach + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}

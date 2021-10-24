using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyThuVien
{
    class BLLSach
    {
        DAL dal = new DAL();
        public DataTable ShowSach()
        {
            string sql = "select * " +
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
                                ,int gia, int namXB, string tacGia, string nhaXB, string maNCC,
                                string nguoiNhap)
        {
            string sql = "insert into Sach values('" + maSach + "', N'" + tenSach + 
                         "', N'" + tinhTrang + "'," + soLuongNhap + ", " + gia + "," + namXB
                         + ", N'" + tacGia + "', N'" + nhaXB + "','" 
                         + maNCC + "', '" + nguoiNhap + "')";

            dal.ExecNonQuery(sql);
        }
        public void UpdateSach(string maSach, string tenSach, string tinhTrang, int soLuongNhap
                                , int gia, int namXB, string tacGia, string nhaXB, string maNCC,
                                string nguoiNhap)
        {

            string sql = "Update Sach set tenSach = N'" + tenSach + "', tinhTrang = N'"
                + tinhTrang + "', soLuongNhap = " + soLuongNhap + ", gia = " + gia +
                ",namXB = " + namXB + ",tacGia = N'" + tacGia + "', nhaXB = N'" + nhaXB +
                "', maNCC = '" + maNCC + "',nguoiNhap = '" + nguoiNhap + "' where  = '" + maSach + "'";
            dal.ExecNonQuery(sql);
        }

        public void DeleteSach(string maSach)
        {
            string sql = "delete Sach where maSach = '" + maSach + "'";
            dal.ExecNonQuery(sql);
        }
    }
}

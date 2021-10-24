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
    class DAL
    {
        public SqlConnection GetConnection()
        {
            String connString =
            @"Data Source=DESKTOP-2021LSA\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                return conn;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable GetTable(String sql)
        {
            SqlConnection conn = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void ExecNonQuery(String sql)
        {
            SqlConnection conn = GetConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY KEY")) MessageBox.Show("Khóa chính bị trùng!");
                else MessageBox.Show(ex.Message);
            }
        }
    }
}

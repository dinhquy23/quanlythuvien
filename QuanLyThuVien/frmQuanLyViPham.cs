using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thư_Viện
{
    public partial class frmQuanLyViPham : Form
    {
        public frmQuanLyViPham()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2021LSA\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True");
        //Thêm
        private void Insert()
        {
            con.Open();
            string sql = "insert into XuLiVP(idPhat,IDLyDo,IDXuLy,ngayXL,nguoiXL,maThe) values(@a,@b,@c,@d,@e,@f)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txtIDphat.Text);
            cmd.Parameters.AddWithValue("b", cbblydo.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("c", cbbxuly.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("d", dtngayxuly.Value);
            cmd.Parameters.AddWithValue("e", cbbnguoixuly.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("f", txtmathevipham.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Sửa
        private void Update()
        {
            con.Open();
            string sql = "update XuLiVP Set IDLyDo=@b,IDXuLy=@c,ngayXL=@d,nguoiXL=@e,maThe=@f where idPhat=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txtIDphat.Text);
            cmd.Parameters.AddWithValue("b", cbblydo.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("c", cbbxuly.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("d", dtngayxuly.Value);
            cmd.Parameters.AddWithValue("e", cbbnguoixuly.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("f", txtmathevipham.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Xóa
        private void Delete()
        {
            con.Open();
            string sql = "delete from XuLiVP where idphat=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txtIDphat.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //kiểm tra tồn tại dữ liệu
        private DataTable Check()
        {
            con.Open();
            string sql = "select idphat from XuLiVP where idPhat=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txtIDphat.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        private DataTable HienThiDuLieu()
        {
            con.Open();
            string sql = "select x.idPhat, l.LyDo, xl.HinhThucXuLy, x.NgayXL,n.hoTenNV,x.maThe from XuLiVP AS x, LyDoVP AS l, NhanVien AS n, XuLy AS xl where l.IDLyDo = x.IDLyDo AND xl.IDXuLy = x.IDXuLy AND x.NguoiXL=n.maNV";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        private DataTable Loadlido()
        {
            con.Open();
            string sql = "select * from LyDoVP";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        private DataTable Loadxuly()
        {
            con.Open();
            string sql = "select * from XuLy";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        private DataTable Loadnhanvien()
        {
            con.Open();
            string sql = "select * from Nhanvien";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                DataTable dt = Check();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Không được thêm trùng ID phạt", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(CheckMaThe())
                    {
                        Insert();
                        MessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Mã thẻ vi phạm không phù hợp", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                dgvdocgiavipham.DataSource = HienThiDuLieu();
            }
        }
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                DataTable dt = Check();
                if (dt.Rows.Count > 0)
                {
                    if(CheckMaThe())
                    {
                        Update();
                        MessageBox.Show("Cập nhật thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                    else
                    {
                        MessageBox.Show("Mã thẻ vi phạm không phù hợp", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại ID phạt này", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                dgvdocgiavipham.DataSource = HienThiDuLieu();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DataTable dt = Check();
            if (dt.Rows.Count > 0)
            {
                DialogResult tl = MessageBox.Show("Bạn muốn xóa ID phạt này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    Delete();
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại ID phạt này", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvdocgiavipham.DataSource = HienThiDuLieu();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmQuanLyViPham_Load(object sender, EventArgs e)
        {
            cbblydo.DataSource = Loadlido();
            cbblydo.DisplayMember = "LyDo";
            cbblydo.ValueMember = "IDLyDo";
            cbbxuly.DataSource = Loadxuly();
            cbbxuly.DisplayMember = "HinhThucXuLy";
            cbbxuly.ValueMember = "IDXuLy";
            cbbnguoixuly.DataSource = Loadnhanvien();
            cbbnguoixuly.DisplayMember = "hotenNV";
            cbbnguoixuly.ValueMember = "maNV";
            dgvdocgiavipham.DataSource = HienThiDuLieu();
        }
        //Cell click
        private void dgvdocgiavipham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtIDphat.Text = dgvdocgiavipham.Rows[index].Cells["idPhat"].Value.ToString();
            cbblydo.Text = dgvdocgiavipham.Rows[index].Cells["LyDo"].Value.ToString();
            cbbxuly.Text = dgvdocgiavipham.Rows[index].Cells["HinhThucXuLy"].Value.ToString();
            txtmathevipham.Text = dgvdocgiavipham.Rows[index].Cells["maThe"].Value.ToString();
            dtngayxuly.Text = dgvdocgiavipham.Rows[index].Cells["ngayXL"].Value.ToString();
            cbbnguoixuly.Text = dgvdocgiavipham.Rows[index].Cells["hoTenNV"].Value.ToString();
        }

        private void txtIDphat_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtIDphat, "");
        }

        private void txtmathevipham_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtmathevipham, "");
        }
        private void dtngayxuly_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtngayxuly, "");
        }
        //valid dữ liệu
        private bool ValidData()
        {
            if (txtIDphat.Text == "")
            {
                errorProvider1.SetError(txtIDphat, "Bạn phải nhập ID phạt");
                txtIDphat.Focus();
                return false;
            }
            else
            {
                if(txtIDphat.Text.Length>10)
                {
                    errorProvider1.SetError(txtIDphat, "Dữ liệu quá dài");
                    txtIDphat.Focus();
                    txtIDphat.SelectAll();
                    return false;
                }
            }
            if (txtmathevipham.Text == "")
            {
                errorProvider1.SetError(txtmathevipham, "Bạn phải nhập mã thẻ vi phạm");
                txtmathevipham.Focus();
                return false;
            }
            if(dtngayxuly.Value>DateTime.Now)
            {
                errorProvider1.SetError(dtngayxuly, "Ngày xử lý phải trước hoặc bằng ngày hiện tại");
                dtngayxuly.Focus();
                return false;
            }
            return true;
        }
        //Lấy mã thẻ thư viện
        private List<string> LayMaTheTV()
        {
            List<string> dsMaTheTV = new List<string>();
            con.Open();
            string sql = "select * from TheTV";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                string maThe = dr["maThe"].ToString();
                dsMaTheTV.Add(maThe);
            }
            con.Close();
            return dsMaTheTV;
        }
        //Kiem tra ma the co phu hop khong
        private bool CheckMaThe()
        {
            int dem = 0;
            foreach(var item in LayMaTheTV())
            {
                if(item==txtmathevipham.Text)
                {
                    dem++;
                }
            }
            if(dem==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

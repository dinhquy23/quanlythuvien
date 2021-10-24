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
    public partial class frmQuanLyDocGia : Form
    {
        public frmQuanLyDocGia()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2021LSA\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True");
        //Hiển thị dữ liệu và load các combobox
        #region
        private void frmQuanLyDocGia_Load(object sender, EventArgs e)
        {
            cbbmathetv.DataSource = Loadmathe();
            cbbmathetv.DisplayMember = "hoTen";
            cbbmathetv.ValueMember = "maThe";
            cbbtinhtrang.DataSource = LoadTinhTrang();
            cbbtinhtrang.DisplayMember = "TinhTrang";
            cbbtinhtrang.ValueMember = "IDTinhTrang";
            HienThiDuLieu();
        }
        //Hiển thị
        private void HienThiDuLieu()
        {
            dgvdocgia.DataSource = HienThiDanhSachDocGia();
            foreach (var item in LayMaDGQuaHan())
            {
                for (int i = 0; i < dgvdocgia.Rows.Count - 1; i++)
                {
                    if (dgvdocgia.Rows[i].Cells["maDG"].Value.ToString() == item.ToString())
                    {
                        dgvdocgia.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                    }
                }
            }
            foreach (var item in LayMaDGBiPhat())
            {
                for (int i = 0; i < dgvdocgia.Rows.Count - 1; i++)
                {
                    if (dgvdocgia.Rows[i].Cells["maDG"].Value.ToString() == item.ToString())
                    {
                        dgvdocgia.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }
        //Lấy dữ liệu từ bảng TheTV
        private DataTable Loadmathe()
        {
            con.Open();
            string sql = "select * from TheTV";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        //Lấy dữ liệu từ bảng TinhTrangDG
        private DataTable LoadTinhTrang()
        {
            con.Open();
            string sql = "select * from TinhTrangDG";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        //Lấy dữ liệu từ bảng DocGia, TinhTrangDG
        private DataTable HienThiDanhSachDocGia()
        {
            con.Open();
            string sql = "select d.maDG,d.tenDangNhap,d.matKhau,d.hoTen,d.DiaChi,d.sdt,d.maThe,t.TinhTrang from DocGia AS d, TinhTrangDG AS t where t.IDTinhTrang = d.IDTinhTrang";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        #endregion
        //Insert, Update, Delete, Search, Check tồn tại
        #region
        //Insert dữ liệu bảng DocGia
        private void Insert()
        {
            con.Open();
            string sql = "Insert into DocGia(maDG,tenDangNhap,matKhau,hoTen,diaChi,sdt,maThe,IDTinhTrang) values(@a,@b,@c,@d,@e,@f,@g,@h)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txtma.Text);
            cmd.Parameters.AddWithValue("b", txttendangnhap.Text);
            cmd.Parameters.AddWithValue("c", txtmatkhau.Text);
            cmd.Parameters.AddWithValue("d", txtten.Text);
            cmd.Parameters.AddWithValue("e", txtdiachi.Text);
            cmd.Parameters.AddWithValue("f", txtsodienthoai.Text);
            cmd.Parameters.AddWithValue("g", cbbmathetv.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("h", cbbtinhtrang.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Update dữ liệu bảng DocGia
        private void Update()
        {
            con.Open();
            string sql = "Update DocGia Set tenDangNhap=@b,matKhau=@c,hoTen=@d,diaChi=@e,sdt=@f,maThe=@g,IDTinhTrang=@h where maDG=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txtma.Text);
            cmd.Parameters.AddWithValue("b", txttendangnhap.Text);
            cmd.Parameters.AddWithValue("c", txtmatkhau.Text);
            cmd.Parameters.AddWithValue("d", txtten.Text);
            cmd.Parameters.AddWithValue("e", txtdiachi.Text);
            cmd.Parameters.AddWithValue("f", txtsodienthoai.Text);
            cmd.Parameters.AddWithValue("g", cbbmathetv.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("h", cbbtinhtrang.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Xóa dữ liệu bảng DocGia
        private void Delete()
        {
            con.Open();
            string sql = "Delete from DocGia where maDG=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txtma.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Tìm kiếm DG theo mã
        private DataTable SearchMa()
        {
            con.Open();
            string sql = "select d.maDG,d.tenDangNhap,d.matKhau,d.hoTen,d.DiaChi,d.sdt,d.maThe,t.TinhTrang from DocGia AS d, TinhTrangDG AS t where t.IDTinhTrang = d.IDTinhTrang AND d.maDG=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txttim.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        //Tìm kiếm DG theo tên
        private DataTable SearchTen()
        {
            con.Open();
            string sql = "select d.maDG,d.tenDangNhap,d.matKhau,d.hoTen,d.DiaChi,d.sdt,d.maThe,t.TinhTrang from DocGia AS d, TinhTrangDG AS t where t.IDTinhTrang = d.IDTinhTrang AND d.hoTen like N'%' +@a+ '%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txttim.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        //Kiểm tra tồn tại dữ liệu
        private DataTable Check()
        {
            con.Open();
            string sql = "select * from DocGia where maDG=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txtma.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            return dt;
        }
        #endregion
        //Thêm, sửa, xóa, tìm kiếm
        #region
        private void btntim_Click(object sender, EventArgs e)
        {
            if (txttim.Text == "")
            {
                MessageBox.Show("Bạn phải điền thông tin để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttim.Focus();
            }
            else
            {
                if (radma.Checked)
                {
                    dgvdocgia.DataSource = SearchMa();
                }
                else if (radten.Checked)
                {
                    dgvdocgia.DataSource = SearchTen();
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                DataTable dt = Check();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Không được thêm trùng mã độc giả", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Insert();
                    MessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                HienThiDuLieu();
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                DataTable dt = Check();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tồn tại độc giả cần sửa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Update();
                    MessageBox.Show("Cập nhật thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                HienThiDuLieu();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DataTable dt = Check();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tồn tại độc giả cần xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult tl = MessageBox.Show("Bạn muốn tiếp tục xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    Delete();
                }
            }
            HienThiDuLieu();
        }
        #endregion
        //Cell click
        private void dgvdocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtma.Text = dgvdocgia.Rows[index].Cells["maDG"].Value.ToString();
            txttendangnhap.Text = dgvdocgia.Rows[index].Cells["tenDangNhap"].Value.ToString();
            txtmatkhau.Text = dgvdocgia.Rows[index].Cells["matKhau"].Value.ToString();
            txtten.Text = dgvdocgia.Rows[index].Cells["hoTen"].Value.ToString();
            txtdiachi.Text = dgvdocgia.Rows[index].Cells["diaChi"].Value.ToString();
            txtsodienthoai.Text = dgvdocgia.Rows[index].Cells["sdt"].Value.ToString();
            cbbmathetv.Text = dgvdocgia.Rows[index].Cells["maThe"].Value.ToString();
            cbbtinhtrang.Text = dgvdocgia.Rows[index].Cells["TinhTrang"].Value.ToString();
        }
        //Lấy mã độc giả quá hạn
        private List<string> LayMaDGQuaHan()
        {
            List<string> dsDocGiaQuaHan = new List<string>();
            con.Open();
            string sql = "select maDG from DocGia where IDTinhTrang='TT03'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string maDGQuaHan = dr["maDG"].ToString();
                dsDocGiaQuaHan.Add(maDGQuaHan);
            }
            con.Close();
            return dsDocGiaQuaHan;
        }
        //Lấy mã độc giả bị phạt
        private List<string> LayMaDGBiPhat()
        {
            List<string> ds = LayDanhSachMaTheBiPhat();
            List<string> dsDocGiaBiPhat = new List<string>();
            foreach (var item in ds)
            {
                con.Open();
                string sql = "select maDG from DocGia where maThe=@a";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("a", item);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string maDGQuaHan = dr["maDG"].ToString();
                    dsDocGiaBiPhat.Add(maDGQuaHan);
                }
                con.Close();
            }
            return dsDocGiaBiPhat;
        }
        //Lấy danh sách mã thẻ bị phạt
        private List<string> LayDanhSachMaTheBiPhat()
        {
            List<string> dsMaTheBiPhat = new List<string>();
            con.Open();
            string sql = "select maThe from XuLiVP";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string maThe = dr["maThe"].ToString();
                dsMaTheBiPhat.Add(maThe);
            }
            con.Close();
            return dsMaTheBiPhat;
        }
        //valid dữ liệu
        #region
        private void txtma_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtma, "");
        }

        private void txttendangnhap_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txttendangnhap, "");
        }

        private void txtmatkhau_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtmatkhau, "");
        }

        private void txtten_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtten, "");
        }

        private void txtdiachi_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtdiachi, "");
        }

        private void txtsodienthoai_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtsodienthoai, "");
        }
        private bool ValidData()
        {
            if (txtma.Text == "")
            {
                errorProvider1.SetError(txtma, "Bạn phải nhập mã độc giả");
                txtma.Focus();
                return false;
            }
            else
            {
                if(txtma.Text.Length>10)
                {
                    errorProvider1.SetError(txtma, "Ký tự quá dài.");
                    txtma.Focus();
                    txtma.SelectAll();
                    return false;
                }
            }
            if (txttendangnhap.Text == "")
            {
                errorProvider1.SetError(txttendangnhap, "Bạn phải nhập tên đăng nhập");
                txttendangnhap.Focus();
                return false;
            }
            if (txtmatkhau.Text == "")
            {
                errorProvider1.SetError(txtmatkhau, "Bạn phải nhập mật khẩu");
                txtmatkhau.Focus();
                return false;
            }
            if (txtten.Text == "")
            {
                errorProvider1.SetError(txtten, "Bạn phải nhập họ tên");
                txtten.Focus();
                return false;
            }
            if (txtdiachi.Text == "")
            {
                errorProvider1.SetError(txtdiachi, "Bạn phải nhập địa chỉ");
                txtdiachi.Focus();
                return false;
            }
            if (txtsodienthoai.Text == "")
            {
                errorProvider1.SetError(txtsodienthoai, "Bạn phải nhập số điện thoại");
                txtsodienthoai.Focus();
                return false;

            }
            else
            {
                try
                {
                    int sdt = int.Parse(txtsodienthoai.Text);
                    if (sdt <= 0)
                    {
                        errorProvider1.SetError(txtsodienthoai, "Số điện thoại phải lớn hơn 0");
                        txtsodienthoai.Focus();
                        txtsodienthoai.SelectAll();
                        return false;
                    }
                }
                catch
                {
                    errorProvider1.SetError(txtsodienthoai, "Số điện thoại phải là số");
                    txtsodienthoai.Focus();
                    txtsodienthoai.SelectAll();
                    return false;
                }
            }
            return true;

        }
        #endregion
    }
}

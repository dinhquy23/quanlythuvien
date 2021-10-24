using System;
using System.Collections.Generic;
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
    public partial class frmQuanLyMuonTraSach : Form
    {
        public frmQuanLyMuonTraSach()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2021LSA\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True");
        //hiển thị dữ liệu và load các combobox
        #region
        private void frmQuanLyMuonTraSach_Load(object sender, EventArgs e)
        {
            radmadg.Checked = true;
            cbbtensach.DataSource = LoadTenSach();
            cbbtensach.DisplayMember = "tenSach";
            cbbtensach.ValueMember = "maSach";
            cbbtinhtrangsach.DataSource = LoadTTSach();
            cbbtinhtrangsach.DisplayMember = "TinhTrangSach";
            cbbtinhtrangsach.ValueMember = "IDTinhTrangSach";
            cbbtrangthai.DataSource = LoadTrangThai();
            cbbtrangthai.DisplayMember = "TrangThai";
            cbbtrangthai.ValueMember = "IDTrangThai";
            cbbnguoilapphieu.DataSource = LoadNhanVien();
            cbbnguoilapphieu.DisplayMember = "hoTenNV";
            cbbnguoilapphieu.ValueMember = "maNV";
            HienThiDanhSachPhieuMuon();
        }
        private void HienThiDanhSachPhieuMuon()
        {
            dgvdanhsachphieumuon.DataSource = HienThiDanhSach();
            List<string> ds = LayMaPhieuChuaDocGiaBiPhat();
            foreach (var item in ds)
            {
                for (int i = 0; i < dgvdanhsachphieumuon.Rows.Count - 1; i++)
                {
                    if (dgvdanhsachphieumuon.Rows[i].Cells["maPhieu"].Value.ToString() == item.ToString())
                    {
                        dgvdanhsachphieumuon.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }
        private DataTable LoadTenSach()
        {
            con.Open();
            string sql = "select * from Sach";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        private DataTable LoadTTSach()
        {
            con.Open();
            string sql = "select * from TinhTrangSach";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        private DataTable LoadTrangThai()
        {
            con.Open();
            string sql = "select * from TrangThai";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        private DataTable LoadNhanVien()
        {
            con.Open();
            string sql = "select * from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        private DataTable HienThiDanhSach()
        {
            con.Open();
            string sql = "select m.maPhieu,m.ngayMuon,m.ngayTra,m.soLuong,t.TinhTrangSach,d.hoTen,n.hoTenNV,s.tenSach,tt.TrangThai from PhieuMuonTra as m,TinhTrangSach as t,DocGia as d,NhanVien as n, Sach as s, TrangThai as tt where m.IDTinhTrangSach=t.IDTinhTrangSach AND m.maDG=d.maDG AND m.nguoiLap=n.maNV AND m.maSach=s.maSach AND m.IDTrangThai=tt.IDTrangThai";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        #endregion
        // Insert dữ liệu
        private void Insert()
        {
            con.Open();
            string sql = "Insert into PhieuMuonTra(maPhieu,ngayMuon,ngayTra,soLuong,IDTinhTrangSach,maDG,nguoiLap,maSach,IDTrangThai) values(@a,@b,@c,@d,@e,@f,@g,@h,@k)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txtmaphieumuon.Text);
            cmd.Parameters.AddWithValue("b", dtngaymuon.Value);
            cmd.Parameters.AddWithValue("c", dtngaytra.Value);
            cmd.Parameters.AddWithValue("d", txtSL.Text);
            cmd.Parameters.AddWithValue("e", cbbtinhtrangsach.SelectedValue);
            cmd.Parameters.AddWithValue("f", txtmaDG.Text);
            cmd.Parameters.AddWithValue("g", cbbnguoilapphieu.SelectedValue);
            cmd.Parameters.AddWithValue("h", cbbtensach.SelectedValue);
            cmd.Parameters.AddWithValue("k", cbbtrangthai.SelectedValue);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Update dữ liệu
        private void Update()
        {
            con.Open();
            string sql = "Update PhieuMuonTra Set ngayMuon=@b,ngayTra=@c,soLuong=@d,IDTinhTrangSach=@e,maDG=@f,nguoiLap=@g,maSach=@h,IDTrangThai=@k where maPhieu=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txtmaphieumuon.Text);
            cmd.Parameters.AddWithValue("b", dtngaymuon.Value);
            cmd.Parameters.AddWithValue("c", dtngaytra.Value);
            cmd.Parameters.AddWithValue("d", txtSL.Text);
            cmd.Parameters.AddWithValue("e", cbbtinhtrangsach.SelectedValue);
            cmd.Parameters.AddWithValue("f", txtmaDG.Text);
            cmd.Parameters.AddWithValue("g", cbbnguoilapphieu.SelectedValue);
            cmd.Parameters.AddWithValue("h", cbbtensach.SelectedValue);
            cmd.Parameters.AddWithValue("k", cbbtrangthai.SelectedValue);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        // Delete dữ liệu
        private void Delete()
        {
            con.Open();
            string sql = "Delete from PhieuMuonTra where maPhieu=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txtmaphieumuon.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        // Kiểm tra tồn tại trong csdl
        private DataTable Check()
        {
            con.Open();
            string sql = "select * from PhieuMuonTra where maPhieu=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txtmaphieumuon.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            return dt;
        }
        // Tìm kiếm bằng mã phiếu mượn trả sách
        private DataTable SearchMaPhieu()
        {
            con.Open();
            string sql = "select m.maPhieu,m.ngayMuon,m.ngayTra,m.soLuong,t.TinhTrangSach,d.hoTen,n.hoTenNV,s.tenSach,tt.TrangThai from PhieuMuonTra as m,TinhTrangSach as t,DocGia as d,NhanVien as n, Sach as s, TrangThai as tt where m.IDTinhTrangSach=t.IDTinhTrangSach AND m.maDG=d.maDG AND m.nguoiLap=n.maNV AND m.maSach=s.maSach AND m.IDTrangThai=tt.IDTrangThai AND m.maPhieu=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txttim.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        //Tìm kiếm bằng mã độc giả
        private DataTable SearchMaDG()
        {
            con.Open();
            string sql = "select m.maPhieu,m.ngayMuon,m.ngayTra,m.soLuong,t.TinhTrangSach,d.hoTen,n.hoTenNV,s.tenSach,tt.TrangThai from PhieuMuonTra as m,TinhTrangSach as t,DocGia as d,NhanVien as n, Sach as s, TrangThai as tt where m.IDTinhTrangSach=t.IDTinhTrangSach AND m.maDG=d.maDG AND m.nguoiLap=n.maNV AND m.maSach=s.maSach AND m.IDTrangThai=tt.IDTrangThai AND m.maDG=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", txttim.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }
        //thêm, sửa, xóa, tìm kiếm, thoát
        #region
        private void btnthem_Click(object sender, EventArgs e)
        {
            int sl = GetSlSachTrongKho();
            int slnhap = int.Parse(txtSL.Text);
            if (ValidData())
            {
                DataTable dt = Check();
                if (dt.Rows.Count == 0)
                {
                    if(CheckMaDG())
                    {
                        if(slnhap>sl)
                        {
                            MessageBox.Show("Số lượng sách trong kho là " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if(CheckDGBiKhoaThe())
                            {
                                Insert();
                                MessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                CapNhatSoLuongSach();
                            }
                            else
                            {
                                MessageBox.Show("Độc giả này đang bị khóa thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã độc giả không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không được thêm trùng mã phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                HienThiDanhSachPhieuMuon();
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            int sl = GetSlSachTrongKho();
            int slnhap = int.Parse(txtSL.Text);
            if (ValidData())
            {
                DataTable dt = Check();
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("Không tồn tại phiếu mượn có mã này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (CheckMaDG())
                    {
                        if (slnhap > sl)
                        {
                            MessageBox.Show("Số lượng sách trong kho là " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Update();
                            MessageBox.Show("Cập nhật thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CapNhatSoLuongSach();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã độc giả không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }
                HienThiDanhSachPhieuMuon();
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            DataTable dt = Check();
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Không tồn tại phiếu mượn có mã này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult tl = MessageBox.Show("Bạn muốn tiếp tục xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(tl==DialogResult.Yes)
                {
                    Delete();
                }
            }
            HienThiDanhSachPhieuMuon();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (txttim.Text == "")
            {
                MessageBox.Show("Bạn phải nhập thông tin để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttim.Focus();
            }
            else
            {
                if (radmadg.Checked == true)
                {
                    dgvdanhsachphieumuon.DataSource=SearchMaDG();
                    List<string> ds = LayMaPhieuChuaDocGiaBiPhat();
                    foreach (var item in ds)
                    {
                        for (int i = 0; i < dgvdanhsachphieumuon.Rows.Count - 1; i++)
                        {
                            if (dgvdanhsachphieumuon.Rows[i].Cells["maPhieu"].Value.ToString() == item.ToString())
                            {
                                dgvdanhsachphieumuon.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                            }
                        }
                    }
                }
                else if (radmaphieu.Checked == true)
                {
                    dgvdanhsachphieumuon.DataSource = SearchMaPhieu();
                    List<string> ds = LayMaPhieuChuaDocGiaBiPhat();
                    foreach (var item in ds)
                    {
                        for (int i = 0; i < dgvdanhsachphieumuon.Rows.Count - 1; i++)
                        {
                            if (dgvdanhsachphieumuon.Rows[i].Cells["maPhieu"].Value.ToString() == item.ToString())
                            {
                                dgvdanhsachphieumuon.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }
        #endregion
        // Cell click
        private void dgvdanhsachphieumuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtmaphieumuon.Text = dgvdanhsachphieumuon.Rows[index].Cells["maPhieu"].Value.ToString();
            dtngaymuon.Text = dgvdanhsachphieumuon.Rows[index].Cells["ngayMuon"].Value.ToString();
            dtngaytra.Text = dgvdanhsachphieumuon.Rows[index].Cells["ngayTra"].Value.ToString();
            cbbtensach.Text = dgvdanhsachphieumuon.Rows[index].Cells["tenSach"].Value.ToString();
            txtSL.Text = dgvdanhsachphieumuon.Rows[index].Cells["soLuong"].Value.ToString();
            txtmaDG.Text = dgvdanhsachphieumuon.Rows[index].Cells["hoTen"].Value.ToString();
            cbbtinhtrangsach.Text = dgvdanhsachphieumuon.Rows[index].Cells["TinhTrangSach"].Value.ToString();
            cbbnguoilapphieu.Text = dgvdanhsachphieumuon.Rows[index].Cells["hoTenNV"].Value.ToString();
            cbbtrangthai.Text = dgvdanhsachphieumuon.Rows[index].Cells["TrangThai"].Value.ToString();
        }
        // Lấy danh sách mã thẻ bị phạt từ bàng XuLiVP
        private List<string> MaTheBiPhat()
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
            //con.Open();
            //List<string> dsDGBiPhat = new List<string>();
            //string sql = "select maDG from DocGia where IDTinhTrang='TT03' OR IDTinhTrang='TT04'";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    string maDGBiPhat = dr["maDG"].ToString();
            //    dsDGBiPhat.Add(maDGBiPhat);
            //}
            //con.Close();
            //return dsDGBiPhat;
        }
        //Lấy Mã ĐG bị phạt thông qua mã thẻ bị phạt
        private List<string> GetDGBiPhat()
        {
            List<string> ds = MaTheBiPhat();
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
      
        // Lấy danh sách mã phiếu có chứa độc giả bị phạt
        private List<string> LayMaPhieuChuaDocGiaBiPhat()
        {
            List<string> ds = GetDGBiPhat();
            List<string> maPhieuPhat = new List<string>();
            foreach (var item in ds)
            {
                con.Open();
                string sql = "select maPhieu from PhieuMuonTra where maDG=@a";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("a", item);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string maPhieu = dr["maPhieu"].ToString();
                    maPhieuPhat.Add(maPhieu);
                }
                con.Close();
            }
            return maPhieuPhat;
        }
        //valid dữ liệu
        #region
        private void txtmaphieumuon_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtmaphieumuon, "");
        }

        private void txtSL_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSL, "");
        }

        private void txtmaDG_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtmaDG, "");
        }

        private void dtngaytra_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtngaytra, "");
        }
        private bool ValidData()
        {
            if (txtmaphieumuon.Text == "")
            {
                errorProvider1.SetError(txtmaphieumuon, "Bạn phải nhập mã phiếu mượn");
                txtmaphieumuon.Focus();
                return false;
            }
            else
            {
                if(txtmaphieumuon.Text.Length>10)
                {
                    errorProvider1.SetError(txtmaphieumuon, "Ký tự quá dài");
                    txtmaphieumuon.Focus();
                    txtmaphieumuon.SelectAll();
                    return false;
                }    
            }
            if (dtngaytra.Value < dtngaymuon.Value)
            {
                errorProvider1.SetError(dtngaytra, "Ngày trả phải muộn hơn ngày mượn");
                dtngaytra.Focus();
                return false;
            }
            if (txtSL.Text == "")
            {
                errorProvider1.SetError(txtSL, "Bạn phải nhập số lượng");
                txtSL.Focus();
                return false;
            }
            else
            {
                try
                {
                    int sl = int.Parse(txtSL.Text);
                    if (sl <= 0)
                    {
                        errorProvider1.SetError(txtSL, "Số lượng phải lớn hơn 0");
                        txtSL.Focus();
                        txtSL.SelectAll();
                        return false;
                    }
                }
                catch
                {
                    errorProvider1.SetError(txtSL, "Số lượng phải là số nguyên");
                    txtSL.Focus();
                    txtSL.SelectAll();
                    return false;
                }
            }
            return true;
        }
        #endregion
        //Kiểm tra ma độc giả có tồn tại trong bảng DocGia không để nhập vào bảng Quản lý mượn trả sách
        private bool CheckMaDG()
        {
            int dem = 0;
            foreach(var item in GetDSMaDG())
            {
                if(txtmaDG.Text==item)
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
        //Lấy danh sách mã độc giả trong bảng DocGia
        private List<string> GetDSMaDG()
        {
            List<string> dsMaDG = new List<string>();
            con.Open();
            string sql = "select maDG from DocGia";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string maDG = dr["maDG"].ToString();
                dsMaDG.Add(maDG);
            }
            con.Close();
            return dsMaDG;
        }
        // Check số lượng sách khi thêm hoặc cập nhật
        private int GetSlSachTrongKho()
        {
            int soLuong = 0;
            con.Open();
            string sql = "select * from Sach where maSach=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", cbbtensach.SelectedValue);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                soLuong = Convert.ToInt32(dr["soLuongNhap"]);
            }
            con.Close();
            return soLuong;
        }

        //Lấy danh sách mã thẻ bị khóa
        private List<string> LayDanhSachMaTheBiKhoa()
        {
            List<string> dsTheBiKhoa = new List<string>();
            con.Open();
            string sql = "select maThe from XuLiVP where IDXuLy='XL02' OR IDXuLy='XL03'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                string maTheKhoa = dr["maThe"].ToString();
                dsTheBiKhoa.Add(maTheKhoa);
            }
            con.Close();
            return dsTheBiKhoa;
        }
        //Lấy đanh sách mã độc giả bị phạt
        private List<string> LayDanhSachMaDGBiKhoa()
        {
            List<string> ds = LayDanhSachMaTheBiKhoa();
            List<string> dsDGBiKhoa = new List<string>();
            foreach (var item in ds)
            {
                con.Open();
                string sql = "select maDG from DocGia where maThe=@a";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("a", item);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string maDGKhoa = dr["maDG"].ToString();
                    dsDGBiKhoa.Add(maDGKhoa);
                }
                con.Close();
            }
            return dsDGBiKhoa;
        }
        // Kiểm tra xem mã độc giả được nhập có nằm trog danh sách độc giả bị khóa tài khoản không
        private bool CheckDGBiKhoaThe()
        {
            List<string> ds = LayDanhSachMaDGBiKhoa();
            foreach(var item in ds)
            {
                if (item == txtmaDG.Text)
                {
                    return false;
                }
            }
            return true;
        }
        //Cập nhật số lượng sách
        private void CapNhatSoLuongSach()
        {
            if (cbbtrangthai.SelectedValue.ToString() == "TT2")
            {
                CapNhapSLSachTra();
            }
            else if (cbbtrangthai.SelectedValue.ToString() == "TT1" || cbbtrangthai.SelectedValue.ToString() == "TT4")
            {
                CapNhapSLSachMuon();
            }
        }
        //Thay đổi số lượng sách khi mượn hoặc quá hạn
        private void CapNhapSLSachMuon()
        {
            int sl = int.Parse(txtSL.Text);
            int slCapNhat = GetSlSachTrongKho() - sl;
            con.Open();
            string sql = "update Sach set soLuongNhap=@b where maSach=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", cbbtensach.SelectedValue);
            cmd.Parameters.AddWithValue("b", slCapNhat);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Thay dổi số lượng sách khi trả
        private void CapNhapSLSachTra()
        {
            int sl = int.Parse(txtSL.Text);
            int slCapNhat = GetSlSachTrongKho() + sl;
            con.Open();
            string sql = "update Sach set soLuongNhap=@b where maSach=@a";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("a", cbbtensach.SelectedValue);
            cmd.Parameters.AddWithValue("b", slCapNhat);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

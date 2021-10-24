using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class fNhanVien : Form
    {
        BLLNhanVien bll = new BLLNhanVien();
        public fNhanVien()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            DataTable dt = new DataTable();
            dt = bll.ShowNhanVien();
            dgvData.DataSource = dt;
        }

        void ClearTextBoxs()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDangNhap.Clear();
            txtMatKhau.Clear();
            dtpNgaySinh.ResetText();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtQuanLy.Clear();
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string ten = txtTenNV.Text;
            string tenDangNhap = txtDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diaChi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string quanLy = txtQuanLy.Text;
            if(ma.Trim() == "" || ten.Trim() == "" || tenDangNhap.Trim() =="" ||
                matKhau.Trim() == "" || diaChi.Trim() == "" || sdt.Trim() == ""||
               quanLy.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!");
                return;
            }
            bll.InsertNhanVien(ma,ten,tenDangNhap,matKhau,ngaySinh,diaChi,sdt,quanLy);
            LoadData();
            ClearTextBoxs();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            if(ma.Trim() == "")
            {
                MessageBox.Show("Ban chua chon nv muon xoa!");
                return;
            }
            DialogResult res = MessageBox.Show("Ban co that su muon xoa?", "Tra loi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                bll.DeleteNhanVien(txtMaNV.Text);
                LoadData();
                MessageBox.Show("Đã xóa thành công", "Thông báo");
                ClearTextBoxs();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string ten = txtTenNV.Text;
            string tenDangNhap = txtDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diaChi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string quanLy = txtQuanLy.Text;
            if (ma.Trim() == "" || ten.Trim() == "" || tenDangNhap.Trim() == "" ||
                matKhau.Trim() == "" || diaChi.Trim() == "" || sdt.Trim() == "" ||
               quanLy.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!");
                return;
            }
            bll.UpdateNhanVien(ma, ten, tenDangNhap, matKhau, ngaySinh, diaChi, sdt, quanLy);
            LoadData();
            ClearTextBoxs();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0) { return; };
            txtMaNV.Text = dgvData.Rows[row].Cells[0].Value.ToString();
            txtTenNV.Text = dgvData.Rows[row].Cells[1].Value.ToString();
            txtDangNhap.Text = dgvData.Rows[row].Cells[2].Value.ToString();
            txtMatKhau.Text = dgvData.Rows[row].Cells[3].Value.ToString();
            dtpNgaySinh.Text = dgvData.Rows[row].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvData.Rows[row].Cells[5].Value.ToString();
            txtSDT.Text = dgvData.Rows[row].Cells[6].Value.ToString();
            txtQuanLy.Text = dgvData.Rows[row].Cells[7].Value.ToString();
        }
    }
}

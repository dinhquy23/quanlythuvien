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
    public partial class fNhapSach : Form
    {
        BLLNhapSach bll = new BLLNhapSach();
        public fNhapSach()
        {
            InitializeComponent();
        }

        private void fThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadMaSach();
            LoadMaNCC();
        }

        void LoadData()
        {
            DataTable dt = new DataTable();
            dt = bll.ShowSach();
            dgvData.DataSource = dt;
        }

        void LoadMaSach()
        {
            DataTable dt = new DataTable();
            dt = bll.ShowMaSach();
            cbbMaSach.DataSource = dt;
            cbbMaSach.DisplayMember = "maSach";
            cbbMaSach.ValueMember = "maSach";
        }
        void LoadMaNCC()
        {
            DataTable dt = new DataTable();
            dt = bll.ShowMaNCC();
            cbbMaNCC.DataSource = dt;
            cbbMaNCC.DisplayMember = "MaNCC";
            cbbMaNCC.ValueMember = "MaNCC";
        }

        void ClearAll()
        {
            cbbMaSach.Items[0].ToString();
            txtTenSach.Clear();
            txtTinhTrang.Clear();
            txtSoLuong.Clear();
            txtGia.Clear();
            txtNamXB.Clear();
            txtTG.Clear();
            txtNhaXB.Clear();
            cbbMaNCC.Items[0].ToString();
            txtNguoiNhap.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSach = cbbMaSach.Text;
            string tenSach = txtTenSach.Text;
            string tinhTrang = txtTinhTrang.Text;
            int soLuongNhap = 0;
            int gia = 0;
            int namXB = 0;
            try
            {
                soLuongNhap = int.Parse(txtSoLuong.Text);
                gia = int.Parse(txtGia.Text);
                namXB = int.Parse(txtNamXB.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Khong phai la so!");
                return;
            }
            string tacGia = txtTG.Text;
            string nhaXB = txtNhaXB.Text;
            string maNCC = cbbMaNCC.Text;
            string nguoiNhap = txtNguoiNhap.Text;
            if (maSach.Trim() == "" || tenSach.Trim() == "" ||
                tinhTrang.Trim() == "" || soLuongNhap.ToString().Trim() == "" ||
                gia.ToString().Trim() == "" || namXB.ToString().Trim() == "" ||
                tacGia.Trim() == "" || nhaXB.Trim() == "" ||
                maNCC.Trim() == "" || nguoiNhap.Trim() == "")
            {
                MessageBox.Show("Ban chua dien day du thong tin!");
                return;
            }
            if (bll.CheckNumSach(maSach).Rows.Count == 0)
            {
                bll.InsertSach(maSach, tenSach, tinhTrang, soLuongNhap, gia, namXB,
                tacGia, nhaXB, maNCC, nguoiNhap);
            }
            else
            {
                bll.UpdateSach(maSach, soLuongNhap);
            }
            LoadData();
            ClearAll();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0) return;
            cbbMaSach.Text = dgvData.Rows[row].Cells[0].Value.ToString();
            txtTenSach.Text = dgvData.Rows[row].Cells[1].Value.ToString();
            txtTinhTrang.Text = dgvData.Rows[row].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvData.Rows[row].Cells[3].Value.ToString();
            txtGia.Text = dgvData.Rows[row].Cells[4].Value.ToString();
            txtNamXB.Text = dgvData.Rows[row].Cells[5].Value.ToString();
            txtTG.Text = dgvData.Rows[row].Cells[6].Value.ToString();
            txtNhaXB.Text = dgvData.Rows[row].Cells[7].Value.ToString();
            cbbMaNCC.Text = dgvData.Rows[row].Cells[8].Value.ToString();
            txtNguoiNhap.Text = dgvData.Rows[row].Cells[9].Value.ToString();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}

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
    public partial class fNhaCC : Form
    {
        BLLNCC bll = new BLLNCC();
        int index = 0;
        public fNhaCC()
        {
            InitializeComponent();
        }
        private void fNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            DataTable dt = new DataTable();
            dt = bll.ShowNCC();
            dgvNCC.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhà cung cấp trống");
                return;
            }
            if (txtTenNCC.Text.Trim() == "")
            {
                MessageBox.Show("Tên Nhà CC trống!");
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ nhà cc trống!");
                return;
            }
            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Sô điện thoại nhà cc trống!");
                return;
            }
            bll.InsertNCC(txtMaNCC.Text, txtTenNCC.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim());
            LoadData();
            ClearAll();
            MessageBox.Show("Đã thêm thành công", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenNCC.Text.Trim() == "")
            {
                MessageBox.Show("Tên Nhà CC trống!");
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ nhà cc trống!");
                return;
            }
            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Sô điện thoại nhà cc trống!");
                return;
            }

            bll.UpdateNCC(txtMaNCC.Text, txtTenNCC.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim());
            LoadData();
            ClearAll();
            MessageBox.Show("Đã Sửa thành công", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            DialogResult res = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                bll.DeleteNCC(txtMaNCC.Text);
                LoadData();
                MessageBox.Show("Đã xóa thành công", "Thông báo");
                ClearAll();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (index == 0)
            {
                MessageBox.Show("Bạn chưa chọn loại tìm kiếm!");
                return;
            }
            else if (index == 1)
            {
                if (txtMaNCC.Text.Trim() == "")
                {
                    MessageBox.Show("Mã tìm kiếm đang trống",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dt = bll.SearchNCC(txtMaNCC.Text.Trim());
                txtTenNCC.Enabled = true;
                txtDiaChi.Enabled = true;
                txtSDT.Enabled = true;
            }
            else if (index == 2)
            {
                if (txtTenNCC.Text.Trim() == "")
                {
                    MessageBox.Show("Tên NCC tìm kiếm đang trống",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dt = bll.SearchNCC1(txtTenNCC.Text.Trim());
                txtMaNCC.Enabled = true;
                txtDiaChi.Enabled = true;
                txtSDT.Enabled = true;
            }
            else if (index == 3)
            {
                if (txtDiaChi.Text.Trim() == "")
                {
                    MessageBox.Show("Địa chỉ tìm kiếm đang trống",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dt = bll.SearchNCC4(txtDiaChi.Text.Trim());
                txtTenNCC.Enabled = true;
                txtMaNCC.Enabled = true;
                txtSDT.Enabled = true;
            }
            else
            {
                if (txtSDT.Text.Trim() == "")
                {
                    MessageBox.Show("Số điện thoại tìm kiếm đang trống",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dt = bll.SearchNCC3(txtSDT.Text.Trim());
                txtTenNCC.Enabled = true;
                txtDiaChi.Enabled = true;
                txtMaNCC.Enabled = true;
            }
            dgvNCC.DataSource = dt;
            ClearAll();
            index = 0;
        }

        void ClearAll()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if(row < 0) { return; }
            txtMaNCC.Text = dgvNCC.Rows[row].Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNCC.Rows[row].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNCC.Rows[row].Cells[2].Value.ToString();
            txtSDT.Text = dgvNCC.Rows[row].Cells[3].Value.ToString();
        }

        private void rdoMa_CheckedChanged(object sender, EventArgs e)
        {
            index = 1;
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
        }

        private void rdoTen_CheckedChanged(object sender, EventArgs e)
        {
            index = 2;
            txtTenNCC.Enabled = true;
            txtMaNCC.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
        }

        private void rdoDC_CheckedChanged(object sender, EventArgs e)
        {
            index = 3;
            txtDiaChi.Enabled = true;
            txtTenNCC.Enabled = false;
            txtMaNCC.Enabled = false;
            txtSDT.Enabled = false;
        }

        private void rdoSDT_CheckedChanged(object sender, EventArgs e)
        {
            index = 4;
            txtSDT.Enabled = true;
            txtTenNCC.Enabled = false;
            txtDiaChi.Enabled = false;
            txtMaNCC.Enabled = false;
        }
    }
}

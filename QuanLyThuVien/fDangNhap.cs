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
    public partial class fDangNhap : Form
    {
        BLLDangNhap data = new BLLDangNhap();
        public fDangNhap()
        {
            InitializeComponent();
        }

        public string user;
        public string password;
        public void btnLogIn_Click(object sender, EventArgs e)
        {
            user = txtUser.Text;
            password = txtPassword.Text;
            DataTable dt = new DataTable();
            dt = data.TaiKhoan(user, password);
            int count;
            count = dt.Rows.Count;
            if (count > 0)
            {
                fThuThu f = new fThuThu();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnLogIn_Click(sender, e);
            }
        }
    }
}

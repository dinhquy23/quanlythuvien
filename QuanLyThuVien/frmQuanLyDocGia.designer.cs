
namespace Quản_Lý_Thư_Viện
{
    partial class frmQuanLyDocGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btntim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radten = new System.Windows.Forms.RadioButton();
            this.radma = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbtinhtrang = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbmathetv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsodienthoai = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvdocgia = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(81, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm độc giả";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btntim);
            this.groupBox3.Controls.Add(this.txttim);
            this.groupBox3.Location = new System.Drawing.Point(498, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập thông tin tìm kiếm";
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(153, 33);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 1;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(28, 36);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(100, 20);
            this.txttim.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radten);
            this.groupBox2.Controls.Add(this.radma);
            this.groupBox2.Location = new System.Drawing.Point(34, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm theo";
            // 
            // radten
            // 
            this.radten.AutoSize = true;
            this.radten.Location = new System.Drawing.Point(146, 36);
            this.radten.Name = "radten";
            this.radten.Size = new System.Drawing.Size(66, 17);
            this.radten.TabIndex = 1;
            this.radten.TabStop = true;
            this.radten.Text = "Tên ĐG:";
            this.radten.UseVisualStyleBackColor = true;
            // 
            // radma
            // 
            this.radma.AutoSize = true;
            this.radma.Location = new System.Drawing.Point(30, 36);
            this.radma.Name = "radma";
            this.radma.Size = new System.Drawing.Size(62, 17);
            this.radma.TabIndex = 0;
            this.radma.TabStop = true;
            this.radma.Text = "Mã ĐG:";
            this.radma.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbbtinhtrang);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cbbmathetv);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtsodienthoai);
            this.groupBox4.Controls.Add(this.txtdiachi);
            this.groupBox4.Controls.Add(this.txtten);
            this.groupBox4.Controls.Add(this.txtmatkhau);
            this.groupBox4.Controls.Add(this.txttendangnhap);
            this.groupBox4.Controls.Add(this.txtma);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(81, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(778, 178);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin độc giả";
            // 
            // cbbtinhtrang
            // 
            this.cbbtinhtrang.FormattingEnabled = true;
            this.cbbtinhtrang.Location = new System.Drawing.Point(125, 144);
            this.cbbtinhtrang.Name = "cbbtinhtrang";
            this.cbbtinhtrang.Size = new System.Drawing.Size(173, 21);
            this.cbbtinhtrang.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tình trạng:";
            // 
            // cbbmathetv
            // 
            this.cbbmathetv.FormattingEnabled = true;
            this.cbbmathetv.Location = new System.Drawing.Point(485, 147);
            this.cbbmathetv.Name = "cbbmathetv";
            this.cbbmathetv.Size = new System.Drawing.Size(175, 21);
            this.cbbmathetv.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mã thẻ TV:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mật khẩu:";
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.Location = new System.Drawing.Point(485, 105);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(175, 20);
            this.txtsodienthoai.TabIndex = 14;
            this.txtsodienthoai.Validated += new System.EventHandler(this.txtsodienthoai_Validated);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(485, 60);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(175, 20);
            this.txtdiachi.TabIndex = 13;
            this.txtdiachi.Validated += new System.EventHandler(this.txtdiachi_Validated);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(485, 15);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(175, 20);
            this.txtten.TabIndex = 12;
            this.txtten.Validated += new System.EventHandler(this.txtten_Validated);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(125, 103);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(173, 20);
            this.txtmatkhau.TabIndex = 10;
            this.txtmatkhau.Validated += new System.EventHandler(this.txtmatkhau_Validated);
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(125, 60);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(173, 20);
            this.txttendangnhap.TabIndex = 9;
            this.txttendangnhap.Validated += new System.EventHandler(this.txttendangnhap_Validated);
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(125, 17);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(173, 20);
            this.txtma.TabIndex = 8;
            this.txtma.Validated += new System.EventHandler(this.txtma_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Họ tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Địa chỉ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ĐG:";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(247, 339);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 32);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(367, 339);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 32);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(487, 339);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 32);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(607, 339);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 32);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvdocgia);
            this.groupBox5.Location = new System.Drawing.Point(25, 377);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(889, 313);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách độc giả";
            // 
            // dgvdocgia
            // 
            this.dgvdocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdocgia.Location = new System.Drawing.Point(6, 16);
            this.dgvdocgia.Name = "dgvdocgia";
            this.dgvdocgia.Size = new System.Drawing.Size(877, 291);
            this.dgvdocgia.TabIndex = 0;
            this.dgvdocgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdocgia_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmQuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(937, 702);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyDocGia";
            this.Text = "Quản lý độc giả";
            this.Load += new System.EventHandler(this.frmQuanLyDocGia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radten;
        private System.Windows.Forms.RadioButton radma;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtsodienthoai;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvdocgia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbmathetv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbtinhtrang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
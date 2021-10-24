
namespace QuanLyThuVien
{
    partial class fNhapSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbMaSach = new System.Windows.Forms.ComboBox();
            this.cbbMaNCC = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNguoiNhap = new System.Windows.Forms.TextBox();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbMaSach);
            this.panel1.Controls.Add(this.cbbMaNCC);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnNhap);
            this.panel1.Controls.Add(this.txtNguoiNhap);
            this.panel1.Controls.Add(this.txtNhaXB);
            this.panel1.Controls.Add(this.txtTG);
            this.panel1.Controls.Add(this.txtNamXB);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtTinhTrang);
            this.panel1.Controls.Add(this.txtTenSach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 295);
            this.panel1.TabIndex = 11;
            // 
            // cbbMaSach
            // 
            this.cbbMaSach.FormattingEnabled = true;
            this.cbbMaSach.Location = new System.Drawing.Point(181, 15);
            this.cbbMaSach.Name = "cbbMaSach";
            this.cbbMaSach.Size = new System.Drawing.Size(240, 28);
            this.cbbMaSach.TabIndex = 25;
            // 
            // cbbMaNCC
            // 
            this.cbbMaNCC.FormattingEnabled = true;
            this.cbbMaNCC.Location = new System.Drawing.Point(645, 149);
            this.cbbMaNCC.Name = "cbbMaNCC";
            this.cbbMaNCC.Size = new System.Drawing.Size(240, 28);
            this.cbbMaNCC.TabIndex = 24;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnHuy.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(125, 245);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 47);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnNhap.FlatAppearance.BorderSize = 0;
            this.btnNhap.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnNhap.Image")));
            this.btnNhap.Location = new System.Drawing.Point(12, 245);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(107, 47);
            this.btnNhap.TabIndex = 21;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtNguoiNhap
            // 
            this.txtNguoiNhap.Location = new System.Drawing.Point(645, 190);
            this.txtNguoiNhap.Name = "txtNguoiNhap";
            this.txtNguoiNhap.Size = new System.Drawing.Size(240, 26);
            this.txtNguoiNhap.TabIndex = 19;
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.Location = new System.Drawing.Point(645, 102);
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(240, 26);
            this.txtNhaXB.TabIndex = 17;
            // 
            // txtTG
            // 
            this.txtTG.Location = new System.Drawing.Point(645, 60);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(240, 26);
            this.txtTG.TabIndex = 16;
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(645, 15);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(240, 26);
            this.txtNamXB.TabIndex = 15;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(181, 190);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(240, 26);
            this.txtGia.TabIndex = 14;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(181, 149);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(240, 26);
            this.txtSoLuong.TabIndex = 13;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(181, 102);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(240, 26);
            this.txtTinhTrang.TabIndex = 12;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(181, 57);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(240, 26);
            this.txtTenSach.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tình trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(520, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Năm xuất bản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(520, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tác giả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(520, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nhà xuất bản:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(520, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mã NCC:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(520, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Người nhập:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 321);
            this.panel2.TabIndex = 12;
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSach,
            this.tenSach,
            this.tinhTrang,
            this.soLuongNhap,
            this.gia,
            this.namXB,
            this.tacGia,
            this.nhaXB,
            this.maNCC,
            this.nguoiNhap});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(949, 321);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // maSach
            // 
            this.maSach.DataPropertyName = "maSach";
            this.maSach.Frozen = true;
            this.maSach.HeaderText = "Mã sách";
            this.maSach.MinimumWidth = 6;
            this.maSach.Name = "maSach";
            this.maSach.Width = 125;
            // 
            // tenSach
            // 
            this.tenSach.DataPropertyName = "tenSach";
            this.tenSach.HeaderText = "Tên sách";
            this.tenSach.MinimumWidth = 6;
            this.tenSach.Name = "tenSach";
            this.tenSach.Width = 125;
            // 
            // tinhTrang
            // 
            this.tinhTrang.DataPropertyName = "tinhTrang";
            this.tinhTrang.HeaderText = "Tình trạng";
            this.tinhTrang.MinimumWidth = 6;
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.Width = 125;
            // 
            // soLuongNhap
            // 
            this.soLuongNhap.DataPropertyName = "soLuongNhap";
            this.soLuongNhap.HeaderText = "Số lượng";
            this.soLuongNhap.MinimumWidth = 6;
            this.soLuongNhap.Name = "soLuongNhap";
            this.soLuongNhap.Width = 125;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.Width = 125;
            // 
            // namXB
            // 
            this.namXB.DataPropertyName = "namXB";
            this.namXB.HeaderText = "Năm xuất bản";
            this.namXB.MinimumWidth = 6;
            this.namXB.Name = "namXB";
            this.namXB.Width = 125;
            // 
            // tacGia
            // 
            this.tacGia.DataPropertyName = "tacGia";
            this.tacGia.HeaderText = "Tác giả";
            this.tacGia.MinimumWidth = 6;
            this.tacGia.Name = "tacGia";
            this.tacGia.Width = 125;
            // 
            // nhaXB
            // 
            this.nhaXB.DataPropertyName = "nhaXB";
            this.nhaXB.HeaderText = "Nhà xuất bản";
            this.nhaXB.MinimumWidth = 6;
            this.nhaXB.Name = "nhaXB";
            this.nhaXB.Width = 125;
            // 
            // maNCC
            // 
            this.maNCC.DataPropertyName = "maNCC";
            this.maNCC.HeaderText = "Mã NCC";
            this.maNCC.MinimumWidth = 6;
            this.maNCC.Name = "maNCC";
            this.maNCC.Width = 125;
            // 
            // nguoiNhap
            // 
            this.nguoiNhap.DataPropertyName = "nguoiNhap";
            this.nguoiNhap.HeaderText = "Người nhập";
            this.nguoiNhap.MinimumWidth = 6;
            this.nguoiNhap.Name = "nguoiNhap";
            this.nguoiNhap.Width = 125;
            // 
            // fNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fNhapSach";
            this.Text = "Nhập sách";
            this.Load += new System.EventHandler(this.fThongTinCaNhan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbMaNCC;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNguoiNhap;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn namXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiNhap;
        private System.Windows.Forms.ComboBox cbbMaSach;
        private System.Windows.Forms.Button btnHuy;
    }
}
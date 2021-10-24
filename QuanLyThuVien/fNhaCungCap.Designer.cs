
namespace QuanLyThuVien
{
    partial class fNhaCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhaCC));
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdoSDT = new System.Windows.Forms.RadioButton();
            this.rdoDC = new System.Windows.Forms.RadioButton();
            this.rdoTen = new System.Windows.Forms.RadioButton();
            this.rdoMa = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grChiTietNhaCC = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grChiTietNhaCC.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNCC
            // 
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.tenNCC,
            this.DiaChi,
            this.SDT});
            this.dgvNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNCC.Location = new System.Drawing.Point(0, 0);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.Size = new System.Drawing.Size(949, 288);
            this.dgvNCC.TabIndex = 3;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.Frozen = true;
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 150;
            // 
            // tenNCC
            // 
            this.tenNCC.DataPropertyName = "tenNCC";
            this.tenNCC.HeaderText = "Tên NCC";
            this.tenNCC.MinimumWidth = 6;
            this.tenNCC.Name = "tenNCC";
            this.tenNCC.Width = 260;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 260;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 230;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 328);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(498, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(451, 328);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.btnTimKiem);
            this.panel5.Controls.Add(this.btnXoa);
            this.panel5.Controls.Add(this.btnThem);
            this.panel5.Controls.Add(this.btnSua);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(451, 328);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.rdoSDT);
            this.panel6.Controls.Add(this.rdoDC);
            this.panel6.Controls.Add(this.rdoTen);
            this.panel6.Controls.Add(this.rdoMa);
            this.panel6.Location = new System.Drawing.Point(122, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(153, 253);
            this.panel6.TabIndex = 13;
            // 
            // rdoSDT
            // 
            this.rdoSDT.AutoSize = true;
            this.rdoSDT.Location = new System.Drawing.Point(16, 196);
            this.rdoSDT.Name = "rdoSDT";
            this.rdoSDT.Size = new System.Drawing.Size(127, 24);
            this.rdoSDT.TabIndex = 3;
            this.rdoSDT.TabStop = true;
            this.rdoSDT.Text = "Số điện thoại";
            this.rdoSDT.UseVisualStyleBackColor = true;
            this.rdoSDT.CheckedChanged += new System.EventHandler(this.rdoSDT_CheckedChanged);
            // 
            // rdoDC
            // 
            this.rdoDC.AutoSize = true;
            this.rdoDC.Location = new System.Drawing.Point(16, 137);
            this.rdoDC.Name = "rdoDC";
            this.rdoDC.Size = new System.Drawing.Size(82, 24);
            this.rdoDC.TabIndex = 2;
            this.rdoDC.TabStop = true;
            this.rdoDC.Text = "Địa chỉ";
            this.rdoDC.UseVisualStyleBackColor = true;
            this.rdoDC.CheckedChanged += new System.EventHandler(this.rdoDC_CheckedChanged);
            // 
            // rdoTen
            // 
            this.rdoTen.AutoSize = true;
            this.rdoTen.Location = new System.Drawing.Point(16, 70);
            this.rdoTen.Name = "rdoTen";
            this.rdoTen.Size = new System.Drawing.Size(99, 24);
            this.rdoTen.TabIndex = 1;
            this.rdoTen.TabStop = true;
            this.rdoTen.Text = "Tên NCC";
            this.rdoTen.UseVisualStyleBackColor = true;
            this.rdoTen.CheckedChanged += new System.EventHandler(this.rdoTen_CheckedChanged);
            // 
            // rdoMa
            // 
            this.rdoMa.AutoSize = true;
            this.rdoMa.Location = new System.Drawing.Point(16, 12);
            this.rdoMa.Name = "rdoMa";
            this.rdoMa.Size = new System.Drawing.Size(94, 24);
            this.rdoMa.TabIndex = 0;
            this.rdoMa.TabStop = true;
            this.rdoMa.Text = "Mã NCC";
            this.rdoMa.UseVisualStyleBackColor = true;
            this.rdoMa.CheckedChanged += new System.EventHandler(this.rdoMa_CheckedChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(320, 26);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 47);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnXoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(320, 254);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 47);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(320, 96);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 47);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnSua.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(320, 174);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 47);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grChiTietNhaCC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 328);
            this.panel3.TabIndex = 0;
            // 
            // grChiTietNhaCC
            // 
            this.grChiTietNhaCC.Controls.Add(this.txtSDT);
            this.grChiTietNhaCC.Controls.Add(this.txtDiaChi);
            this.grChiTietNhaCC.Controls.Add(this.txtTenNCC);
            this.grChiTietNhaCC.Controls.Add(this.label5);
            this.grChiTietNhaCC.Controls.Add(this.label4);
            this.grChiTietNhaCC.Controls.Add(this.label3);
            this.grChiTietNhaCC.Controls.Add(this.label2);
            this.grChiTietNhaCC.Controls.Add(this.txtMaNCC);
            this.grChiTietNhaCC.Dock = System.Windows.Forms.DockStyle.Left;
            this.grChiTietNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grChiTietNhaCC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grChiTietNhaCC.Location = new System.Drawing.Point(0, 0);
            this.grChiTietNhaCC.Name = "grChiTietNhaCC";
            this.grChiTietNhaCC.Size = new System.Drawing.Size(495, 328);
            this.grChiTietNhaCC.TabIndex = 2;
            this.grChiTietNhaCC.TabStop = false;
            this.grChiTietNhaCC.Text = "Chi tiết nhà cung cấp:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(211, 227);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(278, 26);
            this.txtSDT.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(211, 170);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(278, 26);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(211, 115);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(278, 26);
            this.txtTenNCC.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhà cung cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhà cung cấp:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(211, 59);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(278, 26);
            this.txtMaNCC.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvNCC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 288);
            this.panel2.TabIndex = 5;
            // 
            // fNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fNhaCC";
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.fNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.grChiTietNhaCC.ResumeLayout(false);
            this.grChiTietNhaCC.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rdoSDT;
        private System.Windows.Forms.RadioButton rdoDC;
        private System.Windows.Forms.RadioButton rdoTen;
        private System.Windows.Forms.RadioButton rdoMa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grChiTietNhaCC;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}
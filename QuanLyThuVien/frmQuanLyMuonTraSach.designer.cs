
namespace Quản_Lý_Thư_Viện
{
    partial class frmQuanLyMuonTraSach
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtmaDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbtensach = new System.Windows.Forms.ComboBox();
            this.cbbnguoilapphieu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbtrangthai = new System.Windows.Forms.ComboBox();
            this.dtngaytra = new System.Windows.Forms.DateTimePicker();
            this.dtngaymuon = new System.Windows.Forms.DateTimePicker();
            this.cbbtinhtrangsach = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtmaphieumuon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvdanhsachphieumuon = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btntim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radmaphieu = new System.Windows.Forms.RadioButton();
            this.radmadg = new System.Windows.Forms.RadioButton();
            this.btnthem = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachphieumuon)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtmaDG);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbbtensach);
            this.groupBox3.Controls.Add(this.cbbnguoilapphieu);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbbtrangthai);
            this.groupBox3.Controls.Add(this.dtngaytra);
            this.groupBox3.Controls.Add(this.dtngaymuon);
            this.groupBox3.Controls.Add(this.cbbtinhtrangsach);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSL);
            this.groupBox3.Controls.Add(this.txtmaphieumuon);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(48, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(917, 158);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin phiếu mượn";
            // 
            // txtmaDG
            // 
            this.txtmaDG.Location = new System.Drawing.Point(423, 112);
            this.txtmaDG.Name = "txtmaDG";
            this.txtmaDG.Size = new System.Drawing.Size(130, 20);
            this.txtmaDG.TabIndex = 22;
            this.txtmaDG.Validated += new System.EventHandler(this.txtmaDG_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã ĐG:";
            // 
            // cbbtensach
            // 
            this.cbbtensach.FormattingEnabled = true;
            this.cbbtensach.Location = new System.Drawing.Point(423, 25);
            this.cbbtensach.Name = "cbbtensach";
            this.cbbtensach.Size = new System.Drawing.Size(130, 21);
            this.cbbtensach.TabIndex = 20;
            // 
            // cbbnguoilapphieu
            // 
            this.cbbnguoilapphieu.FormattingEnabled = true;
            this.cbbnguoilapphieu.Location = new System.Drawing.Point(713, 69);
            this.cbbnguoilapphieu.Name = "cbbnguoilapphieu";
            this.cbbnguoilapphieu.Size = new System.Drawing.Size(149, 21);
            this.cbbnguoilapphieu.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Người lập phiếu:";
            // 
            // cbbtrangthai
            // 
            this.cbbtrangthai.FormattingEnabled = true;
            this.cbbtrangthai.Location = new System.Drawing.Point(713, 111);
            this.cbbtrangthai.Name = "cbbtrangthai";
            this.cbbtrangthai.Size = new System.Drawing.Size(149, 21);
            this.cbbtrangthai.TabIndex = 17;
            // 
            // dtngaytra
            // 
            this.dtngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaytra.Location = new System.Drawing.Point(139, 114);
            this.dtngaytra.Name = "dtngaytra";
            this.dtngaytra.Size = new System.Drawing.Size(161, 20);
            this.dtngaytra.TabIndex = 16;
            this.dtngaytra.Validated += new System.EventHandler(this.dtngaytra_Validated);
            // 
            // dtngaymuon
            // 
            this.dtngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaymuon.Location = new System.Drawing.Point(139, 70);
            this.dtngaymuon.Name = "dtngaymuon";
            this.dtngaymuon.Size = new System.Drawing.Size(161, 20);
            this.dtngaymuon.TabIndex = 15;
            // 
            // cbbtinhtrangsach
            // 
            this.cbbtinhtrangsach.FormattingEnabled = true;
            this.cbbtinhtrangsach.Location = new System.Drawing.Point(713, 27);
            this.cbbtinhtrangsach.Name = "cbbtinhtrangsach";
            this.cbbtinhtrangsach.Size = new System.Drawing.Size(149, 21);
            this.cbbtinhtrangsach.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Trạng thái:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ngày trả:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ngày mượn:";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(423, 69);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(130, 20);
            this.txtSL.TabIndex = 9;
            this.txtSL.Validated += new System.EventHandler(this.txtSL_Validated);
            // 
            // txtmaphieumuon
            // 
            this.txtmaphieumuon.Location = new System.Drawing.Point(139, 26);
            this.txtmaphieumuon.Name = "txtmaphieumuon";
            this.txtmaphieumuon.Size = new System.Drawing.Size(161, 20);
            this.txtmaphieumuon.TabIndex = 7;
            this.txtmaphieumuon.Validated += new System.EventHandler(this.txtmaphieumuon_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(604, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tình trạng sách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã phiếu mượn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên sách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số lượng:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvdanhsachphieumuon);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(31, 365);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(940, 364);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách phiếu mượn";
            // 
            // dgvdanhsachphieumuon
            // 
            this.dgvdanhsachphieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsachphieumuon.Location = new System.Drawing.Point(6, 19);
            this.dgvdanhsachphieumuon.Name = "dgvdanhsachphieumuon";
            this.dgvdanhsachphieumuon.Size = new System.Drawing.Size(928, 334);
            this.dgvdanhsachphieumuon.TabIndex = 0;
            this.dgvdanhsachphieumuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsachphieumuon_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Location = new System.Drawing.Point(131, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(716, 107);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm độc giả";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btntim);
            this.groupBox6.Controls.Add(this.txttim);
            this.groupBox6.Location = new System.Drawing.Point(427, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(253, 71);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nhập thông tin tìm kiếm";
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(154, 30);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 1;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(29, 33);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(100, 20);
            this.txttim.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radmaphieu);
            this.groupBox7.Controls.Add(this.radmadg);
            this.groupBox7.Location = new System.Drawing.Point(34, 28);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(273, 71);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tìm theo";
            // 
            // radmaphieu
            // 
            this.radmaphieu.AutoSize = true;
            this.radmaphieu.Location = new System.Drawing.Point(146, 33);
            this.radmaphieu.Name = "radmaphieu";
            this.radmaphieu.Size = new System.Drawing.Size(100, 17);
            this.radmaphieu.TabIndex = 1;
            this.radmaphieu.TabStop = true;
            this.radmaphieu.Text = "Mã Phiếu Mượn";
            this.radmaphieu.UseVisualStyleBackColor = true;
            // 
            // radmadg
            // 
            this.radmadg.AutoSize = true;
            this.radmadg.Location = new System.Drawing.Point(22, 33);
            this.radmadg.Name = "radmadg";
            this.radmadg.Size = new System.Drawing.Size(59, 17);
            this.radmadg.TabIndex = 0;
            this.radmadg.TabStop = true;
            this.radmadg.Text = "Mã ĐG";
            this.radmadg.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(235, 318);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 32);
            this.btnthem.TabIndex = 12;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(388, 318);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 32);
            this.btncapnhat.TabIndex = 13;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(541, 318);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 32);
            this.btnxoa.TabIndex = 14;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(694, 318);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 32);
            this.btnthoat.TabIndex = 16;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmQuanLyMuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1002, 730);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmQuanLyMuonTraSach";
            this.Text = "frmQuanLyMuonSach";
            this.Load += new System.EventHandler(this.frmQuanLyMuonTraSach_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachphieumuon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbtrangthai;
        private System.Windows.Forms.DateTimePicker dtngaytra;
        private System.Windows.Forms.DateTimePicker dtngaymuon;
        private System.Windows.Forms.ComboBox cbbtinhtrangsach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtmaphieumuon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvdanhsachphieumuon;
        private System.Windows.Forms.ComboBox cbbnguoilapphieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radmaphieu;
        private System.Windows.Forms.RadioButton radmadg;
        private System.Windows.Forms.ComboBox cbbtensach;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtmaDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
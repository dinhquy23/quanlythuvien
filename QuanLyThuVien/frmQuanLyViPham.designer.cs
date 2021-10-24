
namespace Quản_Lý_Thư_Viện
{
    partial class frmQuanLyViPham
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
            this.dtngayxuly = new System.Windows.Forms.DateTimePicker();
            this.cbbnguoixuly = new System.Windows.Forms.ComboBox();
            this.cbbxuly = new System.Windows.Forms.ComboBox();
            this.cbblydo = new System.Windows.Forms.ComboBox();
            this.txtmathevipham = new System.Windows.Forms.TextBox();
            this.txtIDphat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvdocgiavipham = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocgiavipham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtngayxuly);
            this.groupBox1.Controls.Add(this.cbbnguoixuly);
            this.groupBox1.Controls.Add(this.cbbxuly);
            this.groupBox1.Controls.Add(this.cbblydo);
            this.groupBox1.Controls.Add(this.txtmathevipham);
            this.groupBox1.Controls.Add(this.txtIDphat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin vi phạm";
            // 
            // dtngayxuly
            // 
            this.dtngayxuly.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngayxuly.Location = new System.Drawing.Point(472, 85);
            this.dtngayxuly.Name = "dtngayxuly";
            this.dtngayxuly.Size = new System.Drawing.Size(129, 20);
            this.dtngayxuly.TabIndex = 11;
            this.dtngayxuly.Validated += new System.EventHandler(this.dtngayxuly_Validated);
            // 
            // cbbnguoixuly
            // 
            this.cbbnguoixuly.FormattingEnabled = true;
            this.cbbnguoixuly.Location = new System.Drawing.Point(472, 133);
            this.cbbnguoixuly.Name = "cbbnguoixuly";
            this.cbbnguoixuly.Size = new System.Drawing.Size(129, 21);
            this.cbbnguoixuly.TabIndex = 10;
            // 
            // cbbxuly
            // 
            this.cbbxuly.FormattingEnabled = true;
            this.cbbxuly.Location = new System.Drawing.Point(127, 133);
            this.cbbxuly.Name = "cbbxuly";
            this.cbbxuly.Size = new System.Drawing.Size(162, 21);
            this.cbbxuly.TabIndex = 9;
            // 
            // cbblydo
            // 
            this.cbblydo.FormattingEnabled = true;
            this.cbblydo.Location = new System.Drawing.Point(127, 88);
            this.cbblydo.Name = "cbblydo";
            this.cbblydo.Size = new System.Drawing.Size(162, 21);
            this.cbblydo.TabIndex = 8;
            // 
            // txtmathevipham
            // 
            this.txtmathevipham.Location = new System.Drawing.Point(472, 37);
            this.txtmathevipham.Name = "txtmathevipham";
            this.txtmathevipham.Size = new System.Drawing.Size(129, 20);
            this.txtmathevipham.TabIndex = 7;
            this.txtmathevipham.Validated += new System.EventHandler(this.txtmathevipham_Validated);
            // 
            // txtIDphat
            // 
            this.txtIDphat.Location = new System.Drawing.Point(127, 44);
            this.txtIDphat.Name = "txtIDphat";
            this.txtIDphat.Size = new System.Drawing.Size(162, 20);
            this.txtIDphat.TabIndex = 6;
            this.txtIDphat.Validated += new System.EventHandler(this.txtIDphat_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Người xử lý:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày xử lý:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã thẻ vi phạm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình thức xử lý:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lý do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID phạt:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(117, 227);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(253, 227);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 30);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(389, 227);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(525, 227);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvdocgiavipham);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(41, 278);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(649, 225);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách độc giả vi phạm";
            // 
            // dgvdocgiavipham
            // 
            this.dgvdocgiavipham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdocgiavipham.Location = new System.Drawing.Point(6, 19);
            this.dgvdocgiavipham.Name = "dgvdocgiavipham";
            this.dgvdocgiavipham.Size = new System.Drawing.Size(637, 200);
            this.dgvdocgiavipham.TabIndex = 0;
            this.dgvdocgiavipham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdocgiavipham_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmQuanLyViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(728, 515);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyViPham";
            this.Text = "Quản lý vi phạm";
            this.Load += new System.EventHandler(this.frmQuanLyViPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocgiavipham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtngayxuly;
        private System.Windows.Forms.ComboBox cbbnguoixuly;
        private System.Windows.Forms.ComboBox cbbxuly;
        private System.Windows.Forms.ComboBox cbblydo;
        private System.Windows.Forms.TextBox txtmathevipham;
        private System.Windows.Forms.TextBox txtIDphat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvdocgiavipham;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
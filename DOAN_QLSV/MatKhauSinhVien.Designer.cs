namespace DOAN_QLSV
{
    partial class MatKhauSinhVien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_NhapLai = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMaSV = new System.Windows.Forms.ComboBox();
            this.label_MaMonHoc = new System.Windows.Forms.Label();
            this.label_TenMonHoc = new System.Windows.Forms.Label();
            this.label_SoTiet = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.dgv_MatKhau = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxHoVaTen = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Thoat);
            this.groupBox2.Controls.Add(this.btn_NhapLai);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Location = new System.Drawing.Point(455, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 217);
            this.groupBox2.TabIndex = 98;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Image = global::DOAN_QLSV.Properties.Resources.icon_cancell;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(242, 20);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(47, 50);
            this.btn_Thoat.TabIndex = 89;
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapLai.Image = global::DOAN_QLSV.Properties.Resources.icon_import;
            this.btn_NhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapLai.Location = new System.Drawing.Point(27, 69);
            this.btn_NhapLai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Size = new System.Drawing.Size(145, 37);
            this.btn_NhapLai.TabIndex = 85;
            this.btn_NhapLai.Text = "Nhập lại";
            this.btn_NhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhapLai.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = global::DOAN_QLSV.Properties.Resources.icon_add;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(27, 115);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(145, 37);
            this.btn_Them.TabIndex = 87;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxHoVaTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxMaSV);
            this.groupBox1.Controls.Add(this.label_MaMonHoc);
            this.groupBox1.Controls.Add(this.label_TenMonHoc);
            this.groupBox1.Controls.Add(this.label_SoTiet);
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Location = new System.Drawing.Point(2, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 217);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 82;
            this.label1.Text = "Họ Tên";
            // 
            // cbxMaSV
            // 
            this.cbxMaSV.FormattingEnabled = true;
            this.cbxMaSV.Location = new System.Drawing.Point(144, 42);
            this.cbxMaSV.Name = "cbxMaSV";
            this.cbxMaSV.Size = new System.Drawing.Size(262, 24);
            this.cbxMaSV.TabIndex = 81;
            this.cbxMaSV.SelectedIndexChanged += new System.EventHandler(this.cbxMaSV_SelectedIndexChanged);
            // 
            // label_MaMonHoc
            // 
            this.label_MaMonHoc.AutoSize = true;
            this.label_MaMonHoc.Location = new System.Drawing.Point(28, 42);
            this.label_MaMonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaMonHoc.Name = "label_MaMonHoc";
            this.label_MaMonHoc.Size = new System.Drawing.Size(91, 17);
            this.label_MaMonHoc.TabIndex = 78;
            this.label_MaMonHoc.Text = "Mã Sinh Viên";
            // 
            // label_TenMonHoc
            // 
            this.label_TenMonHoc.AutoSize = true;
            this.label_TenMonHoc.Location = new System.Drawing.Point(28, 133);
            this.label_TenMonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenMonHoc.Name = "label_TenMonHoc";
            this.label_TenMonHoc.Size = new System.Drawing.Size(73, 17);
            this.label_TenMonHoc.TabIndex = 79;
            this.label_TenMonHoc.Text = "Tài Khoản";
            // 
            // label_SoTiet
            // 
            this.label_SoTiet.AutoSize = true;
            this.label_SoTiet.Location = new System.Drawing.Point(28, 181);
            this.label_SoTiet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SoTiet.Name = "label_SoTiet";
            this.label_SoTiet.Size = new System.Drawing.Size(68, 17);
            this.label_SoTiet.TabIndex = 80;
            this.label_SoTiet.Text = "Mật Khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(144, 130);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(262, 22);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(144, 176);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(262, 22);
            this.txtMatKhau.TabIndex = 3;
            // 
            // dgv_MatKhau
            // 
            this.dgv_MatKhau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MatKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MatKhau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TaiKhoan,
            this.MatKhau});
            this.dgv_MatKhau.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_MatKhau.Location = new System.Drawing.Point(0, 288);
            this.dgv_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_MatKhau.Name = "dgv_MatKhau";
            this.dgv_MatKhau.Size = new System.Drawing.Size(761, 208);
            this.dgv_MatKhau.TabIndex = 96;
            this.dgv_MatKhau.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MatKhau_CellDoubleClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã Sinh Viên";
            this.MaSV.Name = "MaSV";
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.DataPropertyName = "TaiKhoan";
            this.TaiKhoan.HeaderText = "Tài Khoản";
            this.TaiKhoan.Name = "TaiKhoan";
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // cbxHoVaTen
            // 
            this.cbxHoVaTen.FormattingEnabled = true;
            this.cbxHoVaTen.Location = new System.Drawing.Point(144, 86);
            this.cbxHoVaTen.Name = "cbxHoVaTen";
            this.cbxHoVaTen.Size = new System.Drawing.Size(262, 24);
            this.cbxHoVaTen.TabIndex = 83;
            // 
            // MatKhauSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_MatKhau);
            this.Name = "MatKhauSinhVien";
            this.Text = "MatKhauSinhVien";
            this.Load += new System.EventHandler(this.MatKhauSinhVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatKhau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_NhapLai;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_MaMonHoc;
        private System.Windows.Forms.Label label_TenMonHoc;
        private System.Windows.Forms.Label label_SoTiet;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.DataGridView dgv_MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.ComboBox cbxMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxHoVaTen;
    }
}
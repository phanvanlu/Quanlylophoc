namespace DOAN_QLSV
{
    partial class QuanLySinhVien
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hinhanh = new System.Windows.Forms.TextBox();
            this.rb_Nu = new System.Windows.Forms.RadioButton();
            this.rb_Nam = new System.Windows.Forms.RadioButton();
            this.cbo_TenLop = new System.Windows.Forms.ComboBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label_MaLop = new System.Windows.Forms.Label();
            this.label_SoDienThoai = new System.Windows.Forms.Label();
            this.txt_BoMe = new System.Windows.Forms.TextBox();
            this.txt_DiemVaoTruong = new System.Windows.Forms.TextBox();
            this.label_HoTenBoMe = new System.Windows.Forms.Label();
            this.label_DiemVaoTruong = new System.Windows.Forms.Label();
            this.label_DiaChi = new System.Windows.Forms.Label();
            this.label_GioiTinh = new System.Windows.Forms.Label();
            this.dgv_HocSinh = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemVaoTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenBoMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.txt_TenHocSinh = new System.Windows.Forms.TextBox();
            this.txt_MaHocSinh = new System.Windows.Forms.TextBox();
            this.label_NgaySinh = new System.Windows.Forms.Label();
            this.label_HoTen = new System.Windows.Forms.Label();
            this.label_MaHS = new System.Windows.Forms.Label();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cmbDiaChi = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Anh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocSinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(60, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 163;
            this.label2.Text = "Ảnh Sinh Viên";
            // 
            // txt_hinhanh
            // 
            this.txt_hinhanh.Location = new System.Drawing.Point(68, 317);
            this.txt_hinhanh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hinhanh.Name = "txt_hinhanh";
            this.txt_hinhanh.Size = new System.Drawing.Size(90, 28);
            this.txt_hinhanh.TabIndex = 160;
            this.txt_hinhanh.TextChanged += new System.EventHandler(this.txt_hinhanh_TextChanged);
            // 
            // rb_Nu
            // 
            this.rb_Nu.AutoSize = true;
            this.rb_Nu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nu.Location = new System.Drawing.Point(507, 146);
            this.rb_Nu.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Nu.Name = "rb_Nu";
            this.rb_Nu.Size = new System.Drawing.Size(56, 26);
            this.rb_Nu.TabIndex = 4;
            this.rb_Nu.TabStop = true;
            this.rb_Nu.Text = "Nữ";
            this.rb_Nu.UseVisualStyleBackColor = true;
            // 
            // rb_Nam
            // 
            this.rb_Nam.AutoSize = true;
            this.rb_Nam.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nam.Location = new System.Drawing.Point(387, 143);
            this.rb_Nam.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Nam.Name = "rb_Nam";
            this.rb_Nam.Size = new System.Drawing.Size(70, 26);
            this.rb_Nam.TabIndex = 3;
            this.rb_Nam.TabStop = true;
            this.rb_Nam.Text = "Nam";
            this.rb_Nam.UseVisualStyleBackColor = true;
            // 
            // cbo_TenLop
            // 
            this.cbo_TenLop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TenLop.FormattingEnabled = true;
            this.cbo_TenLop.Location = new System.Drawing.Point(387, 357);
            this.cbo_TenLop.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_TenLop.Name = "cbo_TenLop";
            this.cbo_TenLop.Size = new System.Drawing.Size(300, 28);
            this.cbo_TenLop.TabIndex = 9;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(387, 320);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(300, 28);
            this.txt_SoDienThoai.TabIndex = 8;
            // 
            // label_MaLop
            // 
            this.label_MaLop.AutoSize = true;
            this.label_MaLop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_MaLop.Location = new System.Drawing.Point(263, 360);
            this.label_MaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaLop.Name = "label_MaLop";
            this.label_MaLop.Size = new System.Drawing.Size(73, 22);
            this.label_MaLop.TabIndex = 154;
            this.label_MaLop.Text = "Tên lớp";
            // 
            // label_SoDienThoai
            // 
            this.label_SoDienThoai.AutoSize = true;
            this.label_SoDienThoai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_SoDienThoai.Location = new System.Drawing.Point(263, 320);
            this.label_SoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SoDienThoai.Name = "label_SoDienThoai";
            this.label_SoDienThoai.Size = new System.Drawing.Size(116, 22);
            this.label_SoDienThoai.TabIndex = 153;
            this.label_SoDienThoai.Text = "Số điện thoại";
            // 
            // txt_BoMe
            // 
            this.txt_BoMe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BoMe.Location = new System.Drawing.Point(387, 273);
            this.txt_BoMe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BoMe.Name = "txt_BoMe";
            this.txt_BoMe.Size = new System.Drawing.Size(300, 28);
            this.txt_BoMe.TabIndex = 7;
            // 
            // txt_DiemVaoTruong
            // 
            this.txt_DiemVaoTruong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiemVaoTruong.Location = new System.Drawing.Point(387, 227);
            this.txt_DiemVaoTruong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiemVaoTruong.Name = "txt_DiemVaoTruong";
            this.txt_DiemVaoTruong.Size = new System.Drawing.Size(300, 28);
            this.txt_DiemVaoTruong.TabIndex = 6;
            // 
            // label_HoTenBoMe
            // 
            this.label_HoTenBoMe.AutoSize = true;
            this.label_HoTenBoMe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HoTenBoMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_HoTenBoMe.Location = new System.Drawing.Point(263, 273);
            this.label_HoTenBoMe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_HoTenBoMe.Name = "label_HoTenBoMe";
            this.label_HoTenBoMe.Size = new System.Drawing.Size(118, 22);
            this.label_HoTenBoMe.TabIndex = 150;
            this.label_HoTenBoMe.Text = "Họ tên bố mẹ";
            // 
            // label_DiemVaoTruong
            // 
            this.label_DiemVaoTruong.AutoSize = true;
            this.label_DiemVaoTruong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DiemVaoTruong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_DiemVaoTruong.Location = new System.Drawing.Point(263, 231);
            this.label_DiemVaoTruong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DiemVaoTruong.Name = "label_DiemVaoTruong";
            this.label_DiemVaoTruong.Size = new System.Drawing.Size(148, 22);
            this.label_DiemVaoTruong.TabIndex = 149;
            this.label_DiemVaoTruong.Text = "Điểm vào trường";
            // 
            // label_DiaChi
            // 
            this.label_DiaChi.AutoSize = true;
            this.label_DiaChi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_DiaChi.Location = new System.Drawing.Point(263, 191);
            this.label_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(68, 22);
            this.label_DiaChi.TabIndex = 141;
            this.label_DiaChi.Text = "Địa chỉ";
            // 
            // label_GioiTinh
            // 
            this.label_GioiTinh.AutoSize = true;
            this.label_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_GioiTinh.Location = new System.Drawing.Point(263, 148);
            this.label_GioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GioiTinh.Name = "label_GioiTinh";
            this.label_GioiTinh.Size = new System.Drawing.Size(82, 22);
            this.label_GioiTinh.TabIndex = 140;
            this.label_GioiTinh.Text = "Giới tính";
            // 
            // dgv_HocSinh
            // 
            this.dgv_HocSinh.AllowUserToAddRows = false;
            this.dgv_HocSinh.AllowUserToDeleteRows = false;
            this.dgv_HocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.DiemVaoTruong,
            this.HoTenBoMe,
            this.SoDienThoai,
            this.HinhAnh,
            this.MaLop});
            this.dgv_HocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_HocSinh.Location = new System.Drawing.Point(0, 0);
            this.dgv_HocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_HocSinh.Name = "dgv_HocSinh";
            this.dgv_HocSinh.ReadOnly = true;
            this.dgv_HocSinh.Size = new System.Drawing.Size(1321, 302);
            this.dgv_HocSinh.TabIndex = 139;
            this.dgv_HocSinh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HocSinh_CellDoubleClick);
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaSV";
            this.MaHS.FillWeight = 94.19066F;
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.Name = "MaHS";
            this.MaHS.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.FillWeight = 152.2843F;
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.FillWeight = 94.19066F;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.FillWeight = 94.19066F;
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.FillWeight = 94.19066F;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // DiemVaoTruong
            // 
            this.DiemVaoTruong.DataPropertyName = "DiemVaoTruong";
            this.DiemVaoTruong.FillWeight = 94.19066F;
            this.DiemVaoTruong.HeaderText = "Điểm vào trường";
            this.DiemVaoTruong.Name = "DiemVaoTruong";
            this.DiemVaoTruong.ReadOnly = true;
            // 
            // HoTenBoMe
            // 
            this.HoTenBoMe.DataPropertyName = "HoTenBoMe";
            this.HoTenBoMe.FillWeight = 94.19066F;
            this.HoTenBoMe.HeaderText = "Họ tên bố mẹ";
            this.HoTenBoMe.Name = "HoTenBoMe";
            this.HoTenBoMe.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.FillWeight = 94.19066F;
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.FillWeight = 94.19066F;
            this.HinhAnh.HeaderText = "Hình Ảnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.FillWeight = 94.19066F;
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(29, 34);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Multiline = true;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(437, 28);
            this.txt_TimKiem.TabIndex = 136;
            // 
            // txt_TenHocSinh
            // 
            this.txt_TenHocSinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHocSinh.Location = new System.Drawing.Point(387, 66);
            this.txt_TenHocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenHocSinh.Name = "txt_TenHocSinh";
            this.txt_TenHocSinh.Size = new System.Drawing.Size(300, 28);
            this.txt_TenHocSinh.TabIndex = 2;
            // 
            // txt_MaHocSinh
            // 
            this.txt_MaHocSinh.Enabled = false;
            this.txt_MaHocSinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHocSinh.Location = new System.Drawing.Point(387, 30);
            this.txt_MaHocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaHocSinh.Name = "txt_MaHocSinh";
            this.txt_MaHocSinh.Size = new System.Drawing.Size(300, 28);
            this.txt_MaHocSinh.TabIndex = 1;
            // 
            // label_NgaySinh
            // 
            this.label_NgaySinh.AutoSize = true;
            this.label_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_NgaySinh.Location = new System.Drawing.Point(263, 107);
            this.label_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NgaySinh.Name = "label_NgaySinh";
            this.label_NgaySinh.Size = new System.Drawing.Size(91, 22);
            this.label_NgaySinh.TabIndex = 132;
            this.label_NgaySinh.Text = "Ngày sinh";
            // 
            // label_HoTen
            // 
            this.label_HoTen.AutoSize = true;
            this.label_HoTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_HoTen.Location = new System.Drawing.Point(263, 69);
            this.label_HoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_HoTen.Name = "label_HoTen";
            this.label_HoTen.Size = new System.Drawing.Size(64, 22);
            this.label_HoTen.TabIndex = 131;
            this.label_HoTen.Text = "Họ tên";
            // 
            // label_MaHS
            // 
            this.label_MaHS.AutoSize = true;
            this.label_MaHS.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaHS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_MaHS.Location = new System.Drawing.Point(263, 33);
            this.label_MaHS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaHS.Name = "label_MaHS";
            this.label_MaHS.Size = new System.Drawing.Size(114, 22);
            this.label_MaHS.TabIndex = 130;
            this.label_MaHS.Text = "Mã sinh viên";
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngaysinh.Location = new System.Drawing.Point(387, 107);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(300, 28);
            this.dtngaysinh.TabIndex = 164;
            // 
            // cmbDiaChi
            // 
            this.cmbDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiaChi.FormattingEnabled = true;
            this.cmbDiaChi.Location = new System.Drawing.Point(387, 188);
            this.cmbDiaChi.Name = "cmbDiaChi";
            this.cmbDiaChi.Size = new System.Drawing.Size(300, 28);
            this.cmbDiaChi.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cbo_TenLop);
            this.groupBox1.Controls.Add(this.cmbDiaChi);
            this.groupBox1.Controls.Add(this.txt_SoDienThoai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_BoMe);
            this.groupBox1.Controls.Add(this.rb_Nu);
            this.groupBox1.Controls.Add(this.txt_DiemVaoTruong);
            this.groupBox1.Controls.Add(this.dtngaysinh);
            this.groupBox1.Controls.Add(this.rb_Nam);
            this.groupBox1.Controls.Add(this.btn_Anh);
            this.groupBox1.Controls.Add(this.txt_hinhanh);
            this.groupBox1.Controls.Add(this.label_MaHS);
            this.groupBox1.Controls.Add(this.label_HoTen);
            this.groupBox1.Controls.Add(this.label_NgaySinh);
            this.groupBox1.Controls.Add(this.label_MaLop);
            this.groupBox1.Controls.Add(this.label_GioiTinh);
            this.groupBox1.Controls.Add(this.label_SoDienThoai);
            this.groupBox1.Controls.Add(this.label_DiaChi);
            this.groupBox1.Controls.Add(this.label_DiemVaoTruong);
            this.groupBox1.Controls.Add(this.label_HoTenBoMe);
            this.groupBox1.Controls.Add(this.txt_MaHocSinh);
            this.groupBox1.Controls.Add(this.txt_TenHocSinh);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 399);
            this.groupBox1.TabIndex = 166;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(20, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 236);
            this.pictureBox1.TabIndex = 161;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Anh
            // 
            this.btn_Anh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anh.Image = global::DOAN_QLSV.Properties.Resources.icon_see;
            this.btn_Anh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Anh.Location = new System.Drawing.Point(47, 306);
            this.btn_Anh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Anh.Name = "btn_Anh";
            this.btn_Anh.Size = new System.Drawing.Size(138, 44);
            this.btn_Anh.TabIndex = 162;
            this.btn_Anh.Text = "Thêm Ảnh";
            this.btn_Anh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Anh.UseVisualStyleBackColor = true;
            this.btn_Anh.Click += new System.EventHandler(this.btn_Anh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_TimKiem);
            this.groupBox2.Controls.Add(this.btn_TimKiem);
            this.groupBox2.Controls.Add(this.btnNhapLai);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(778, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 397);
            this.groupBox2.TabIndex = 167;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Image = global::DOAN_QLSV.Properties.Resources.icon_search;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(474, 34);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(34, 29);
            this.btn_TimKiem.TabIndex = 137;
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Image = global::DOAN_QLSV.Properties.Resources.icon_import;
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.Location = new System.Drawing.Point(51, 107);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(140, 50);
            this.btnNhapLai.TabIndex = 143;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Image = global::DOAN_QLSV.Properties.Resources.icon_erase;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(308, 214);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(140, 50);
            this.btnxoa.TabIndex = 148;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Image = global::DOAN_QLSV.Properties.Resources.icon_add;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(51, 214);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(140, 50);
            this.btnthem.TabIndex = 145;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Image = global::DOAN_QLSV.Properties.Resources.icon_update;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(308, 107);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(140, 50);
            this.btnsua.TabIndex = 146;
            this.btnsua.Text = "Cập nhật";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1321, 713);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_HocSinh);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLySinhVien";
            this.Text = "QuanLySinhVien";
            this.Load += new System.EventHandler(this.QuanLySinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocSinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Anh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_hinhanh;
        private System.Windows.Forms.RadioButton rb_Nu;
        private System.Windows.Forms.RadioButton rb_Nam;
        private System.Windows.Forms.ComboBox cbo_TenLop;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.Label label_MaLop;
        private System.Windows.Forms.Label label_SoDienThoai;
        private System.Windows.Forms.TextBox txt_BoMe;
        private System.Windows.Forms.TextBox txt_DiemVaoTruong;
        private System.Windows.Forms.Label label_HoTenBoMe;
        private System.Windows.Forms.Label label_DiemVaoTruong;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Label label_DiaChi;
        private System.Windows.Forms.Label label_GioiTinh;
        private System.Windows.Forms.DataGridView dgv_HocSinh;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.TextBox txt_TenHocSinh;
        private System.Windows.Forms.TextBox txt_MaHocSinh;
        private System.Windows.Forms.Label label_NgaySinh;
        private System.Windows.Forms.Label label_HoTen;
        private System.Windows.Forms.Label label_MaHS;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.ComboBox cmbDiaChi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemVaoTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenBoMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
    }
}
namespace DOAN_QLSV
{
    partial class DanhSachSinhVien1Lop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachSinhVien1Lop));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.cbb_giaovienchunhiem = new System.Windows.Forms.ComboBox();
            this.cbb_siso = new System.Windows.Forms.ComboBox();
            this.cbb_nienkhoa = new System.Windows.Forms.ComboBox();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemVaoTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenBoMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_tenlop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_indshs1lop = new System.Windows.Forms.Button();
            this.btn_hienthidanhsachhocsinh = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_trovetrangchu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // cbb_giaovienchunhiem
            // 
            this.cbb_giaovienchunhiem.FormattingEnabled = true;
            this.cbb_giaovienchunhiem.Location = new System.Drawing.Point(248, 197);
            this.cbb_giaovienchunhiem.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_giaovienchunhiem.Name = "cbb_giaovienchunhiem";
            this.cbb_giaovienchunhiem.Size = new System.Drawing.Size(245, 28);
            this.cbb_giaovienchunhiem.TabIndex = 94;
            // 
            // cbb_siso
            // 
            this.cbb_siso.FormattingEnabled = true;
            this.cbb_siso.Location = new System.Drawing.Point(143, 143);
            this.cbb_siso.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_siso.Name = "cbb_siso";
            this.cbb_siso.Size = new System.Drawing.Size(350, 28);
            this.cbb_siso.TabIndex = 93;
            // 
            // cbb_nienkhoa
            // 
            this.cbb_nienkhoa.FormattingEnabled = true;
            this.cbb_nienkhoa.Location = new System.Drawing.Point(143, 89);
            this.cbb_nienkhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_nienkhoa.Name = "cbb_nienkhoa";
            this.cbb_nienkhoa.Size = new System.Drawing.Size(350, 28);
            this.cbb_nienkhoa.TabIndex = 92;
            // 
            // dtg
            // 
            this.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.DiemVaoTruong,
            this.HoTenBoMe,
            this.SoDienThoai});
            this.dtg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg.Location = new System.Drawing.Point(0, 281);
            this.dtg.Margin = new System.Windows.Forms.Padding(4);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(1349, 291);
            this.dtg.TabIndex = 90;
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaSV";
            this.MaHS.HeaderText = "Mã Sinh Viên";
            this.MaHS.Name = "MaHS";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên Học Sinh";
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // DiemVaoTruong
            // 
            this.DiemVaoTruong.DataPropertyName = "DiemVaoTruong";
            this.DiemVaoTruong.HeaderText = "Điểm Vào Trường";
            this.DiemVaoTruong.Name = "DiemVaoTruong";
            // 
            // HoTenBoMe
            // 
            this.HoTenBoMe.DataPropertyName = "HoTenBoMe";
            this.HoTenBoMe.HeaderText = "Họ Tên Bố Mẹ";
            this.HoTenBoMe.Name = "HoTenBoMe";
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(35, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 22);
            this.label4.TabIndex = 87;
            this.label4.Text = "Giáo Viên Chủ Nhiệm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(35, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 85;
            this.label2.Text = "Niên Khóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(35, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 86;
            this.label3.Text = "Sĩ Số";
            // 
            // cbb_tenlop
            // 
            this.cbb_tenlop.FormattingEnabled = true;
            this.cbb_tenlop.Location = new System.Drawing.Point(143, 31);
            this.cbb_tenlop.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_tenlop.Name = "cbb_tenlop";
            this.cbb_tenlop.Size = new System.Drawing.Size(350, 28);
            this.cbb_tenlop.TabIndex = 84;
            this.cbb_tenlop.SelectedIndexChanged += new System.EventHandler(this.cbb_tenlop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 82;
            this.label1.Text = "Tên Lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_tenlop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbb_giaovienchunhiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbb_siso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbb_nienkhoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 244);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_indshs1lop);
            this.groupBox2.Controls.Add(this.btn_hienthidanhsachhocsinh);
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.btn_trovetrangchu);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(730, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 244);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_indshs1lop
            // 
            this.btn_indshs1lop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_indshs1lop.Image = global::DOAN_QLSV.Properties.Resources.icon_print;
            this.btn_indshs1lop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_indshs1lop.Location = new System.Drawing.Point(33, 180);
            this.btn_indshs1lop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_indshs1lop.Name = "btn_indshs1lop";
            this.btn_indshs1lop.Size = new System.Drawing.Size(206, 46);
            this.btn_indshs1lop.TabIndex = 91;
            this.btn_indshs1lop.Text = "In Danh Sách";
            this.btn_indshs1lop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_indshs1lop.UseVisualStyleBackColor = true;
            this.btn_indshs1lop.Click += new System.EventHandler(this.btn_indshs1lop_Click);
            // 
            // btn_hienthidanhsachhocsinh
            // 
            this.btn_hienthidanhsachhocsinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthidanhsachhocsinh.Image = global::DOAN_QLSV.Properties.Resources.icon_see;
            this.btn_hienthidanhsachhocsinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hienthidanhsachhocsinh.Location = new System.Drawing.Point(33, 58);
            this.btn_hienthidanhsachhocsinh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hienthidanhsachhocsinh.Name = "btn_hienthidanhsachhocsinh";
            this.btn_hienthidanhsachhocsinh.Size = new System.Drawing.Size(237, 46);
            this.btn_hienthidanhsachhocsinh.TabIndex = 89;
            this.btn_hienthidanhsachhocsinh.Text = "Hiển Thị Danh Sách ";
            this.btn_hienthidanhsachhocsinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hienthidanhsachhocsinh.UseVisualStyleBackColor = true;
            this.btn_hienthidanhsachhocsinh.Click += new System.EventHandler(this.btn_hienthidanhsachhocsinh_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Image = global::DOAN_QLSV.Properties.Resources.icon_reset;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(285, 180);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(156, 46);
            this.btn_reset.TabIndex = 95;
            this.btn_reset.Text = "Trở Lại";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_trovetrangchu
            // 
            this.btn_trovetrangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trovetrangchu.Image = global::DOAN_QLSV.Properties.Resources.icon_cancell;
            this.btn_trovetrangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trovetrangchu.Location = new System.Drawing.Point(339, 58);
            this.btn_trovetrangchu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_trovetrangchu.Name = "btn_trovetrangchu";
            this.btn_trovetrangchu.Size = new System.Drawing.Size(58, 51);
            this.btn_trovetrangchu.TabIndex = 83;
            this.btn_trovetrangchu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_trovetrangchu.UseVisualStyleBackColor = true;
            this.btn_trovetrangchu.Click += new System.EventHandler(this.btn_trovetrangchu_Click);
            // 
            // DanhSachSinhVien1Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1349, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DanhSachSinhVien1Lop";
            this.Text = "DanhSachSinhVien1Lop";
            this.Load += new System.EventHandler(this.DanhSachSinhVien1Lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox cbb_giaovienchunhiem;
        private System.Windows.Forms.ComboBox cbb_siso;
        private System.Windows.Forms.ComboBox cbb_nienkhoa;
        private System.Windows.Forms.Button btn_indshs1lop;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Button btn_hienthidanhsachhocsinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_tenlop;
        private System.Windows.Forms.Button btn_trovetrangchu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemVaoTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenBoMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
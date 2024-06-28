namespace DOAN_QLSV
{
    partial class DanhSachGiaoVien1Lop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachGiaoVien1Lop));
            this.cbb_giaovienchunhiem = new System.Windows.Forms.ComboBox();
            this.cbb_siso = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.cbb_nienkhoa = new System.Windows.Forms.ComboBox();
            this.cbb_tenlop = new System.Windows.Forms.ComboBox();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.MaCanBoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPhanCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_hienthidanhsachgiaovien = new System.Windows.Forms.Button();
            this.btn_indsgv1lop = new System.Windows.Forms.Button();
            this.btn_trovetrangchu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_giaovienchunhiem
            // 
            this.cbb_giaovienchunhiem.FormattingEnabled = true;
            this.cbb_giaovienchunhiem.Location = new System.Drawing.Point(255, 175);
            this.cbb_giaovienchunhiem.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_giaovienchunhiem.Name = "cbb_giaovienchunhiem";
            this.cbb_giaovienchunhiem.Size = new System.Drawing.Size(234, 28);
            this.cbb_giaovienchunhiem.TabIndex = 107;
            // 
            // cbb_siso
            // 
            this.cbb_siso.FormattingEnabled = true;
            this.cbb_siso.Location = new System.Drawing.Point(169, 137);
            this.cbb_siso.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_siso.Name = "cbb_siso";
            this.cbb_siso.Size = new System.Drawing.Size(162, 28);
            this.cbb_siso.TabIndex = 106;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // cbb_nienkhoa
            // 
            this.cbb_nienkhoa.FormattingEnabled = true;
            this.cbb_nienkhoa.Location = new System.Drawing.Point(169, 85);
            this.cbb_nienkhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_nienkhoa.Name = "cbb_nienkhoa";
            this.cbb_nienkhoa.Size = new System.Drawing.Size(162, 28);
            this.cbb_nienkhoa.TabIndex = 105;
            // 
            // cbb_tenlop
            // 
            this.cbb_tenlop.FormattingEnabled = true;
            this.cbb_tenlop.Location = new System.Drawing.Point(169, 33);
            this.cbb_tenlop.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_tenlop.Name = "cbb_tenlop";
            this.cbb_tenlop.Size = new System.Drawing.Size(320, 28);
            this.cbb_tenlop.TabIndex = 104;
            this.cbb_tenlop.SelectedIndexChanged += new System.EventHandler(this.cbb_tenlop_SelectedIndexChanged);
            // 
            // dtg
            // 
            this.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCanBoGV,
            this.HoTen,
            this.TenMH,
            this.NgayPhanCong,
            this.SoDienThoai});
            this.dtg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg.Location = new System.Drawing.Point(0, 287);
            this.dtg.Margin = new System.Windows.Forms.Padding(4);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(1018, 291);
            this.dtg.TabIndex = 102;
            // 
            // MaCanBoGV
            // 
            this.MaCanBoGV.DataPropertyName = "MaGiaoVien";
            this.MaCanBoGV.FillWeight = 76.14212F;
            this.MaCanBoGV.HeaderText = "Mã Giáo Viên";
            this.MaCanBoGV.Name = "MaCanBoGV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.FillWeight = 109.2562F;
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.FillWeight = 109.2562F;
            this.TenMH.HeaderText = "Tên Môn Học";
            this.TenMH.Name = "TenMH";
            // 
            // NgayPhanCong
            // 
            this.NgayPhanCong.DataPropertyName = "NgayHoc";
            this.NgayPhanCong.FillWeight = 109.2562F;
            this.NgayPhanCong.HeaderText = "Ngày Dạy";
            this.NgayPhanCong.Name = "NgayPhanCong";
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.FillWeight = 96.08917F;
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 22);
            this.label4.TabIndex = 99;
            this.label4.Text = "Giáo Viên Chủ Nhiệm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 98;
            this.label3.Text = "Sĩ Số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 97;
            this.label2.Text = "Niên Khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 95;
            this.label1.Text = "Tên Lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbb_siso);
            this.groupBox1.Controls.Add(this.cbb_giaovienchunhiem);
            this.groupBox1.Controls.Add(this.cbb_nienkhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbb_tenlop);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 231);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.btn_hienthidanhsachgiaovien);
            this.groupBox2.Controls.Add(this.btn_indsgv1lop);
            this.groupBox2.Controls.Add(this.btn_trovetrangchu);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(582, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 231);
            this.groupBox2.TabIndex = 109;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Image = global::DOAN_QLSV.Properties.Resources.icon_reset;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(232, 85);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(129, 43);
            this.btn_reset.TabIndex = 104;
            this.btn_reset.Text = "Trở Lại";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_hienthidanhsachgiaovien
            // 
            this.btn_hienthidanhsachgiaovien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthidanhsachgiaovien.Image = global::DOAN_QLSV.Properties.Resources.icon_see;
            this.btn_hienthidanhsachgiaovien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hienthidanhsachgiaovien.Location = new System.Drawing.Point(25, 85);
            this.btn_hienthidanhsachgiaovien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hienthidanhsachgiaovien.Name = "btn_hienthidanhsachgiaovien";
            this.btn_hienthidanhsachgiaovien.Size = new System.Drawing.Size(143, 46);
            this.btn_hienthidanhsachgiaovien.TabIndex = 101;
            this.btn_hienthidanhsachgiaovien.Text = "Hiển Thị";
            this.btn_hienthidanhsachgiaovien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hienthidanhsachgiaovien.UseVisualStyleBackColor = true;
            this.btn_hienthidanhsachgiaovien.Click += new System.EventHandler(this.btn_hienthidanhsachgiaovien_Click);
            // 
            // btn_indsgv1lop
            // 
            this.btn_indsgv1lop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_indsgv1lop.Image = global::DOAN_QLSV.Properties.Resources.icon_print;
            this.btn_indsgv1lop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_indsgv1lop.Location = new System.Drawing.Point(65, 157);
            this.btn_indsgv1lop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_indsgv1lop.Name = "btn_indsgv1lop";
            this.btn_indsgv1lop.Size = new System.Drawing.Size(269, 46);
            this.btn_indsgv1lop.TabIndex = 103;
            this.btn_indsgv1lop.Text = "In Danh Sách Giáo Viên ";
            this.btn_indsgv1lop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_indsgv1lop.UseVisualStyleBackColor = true;
            this.btn_indsgv1lop.Click += new System.EventHandler(this.btn_indsgv1lop_Click);
            // 
            // btn_trovetrangchu
            // 
            this.btn_trovetrangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trovetrangchu.Image = global::DOAN_QLSV.Properties.Resources.icon_cancell;
            this.btn_trovetrangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trovetrangchu.Location = new System.Drawing.Point(335, 26);
            this.btn_trovetrangchu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_trovetrangchu.Name = "btn_trovetrangchu";
            this.btn_trovetrangchu.Size = new System.Drawing.Size(39, 46);
            this.btn_trovetrangchu.TabIndex = 96;
            this.btn_trovetrangchu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_trovetrangchu.UseVisualStyleBackColor = true;
            this.btn_trovetrangchu.Click += new System.EventHandler(this.btn_trovetrangchu_Click);
            // 
            // DanhSachGiaoVien1Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1018, 578);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DanhSachGiaoVien1Lop";
            this.Text = "DanhSachGiaoVien1Lop";
            this.Load += new System.EventHandler(this.DanhSachGiaoVien1Lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_giaovienchunhiem;
        private System.Windows.Forms.ComboBox cbb_siso;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox cbb_nienkhoa;
        private System.Windows.Forms.ComboBox cbb_tenlop;
        private System.Windows.Forms.Button btn_indsgv1lop;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_hienthidanhsachgiaovien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_trovetrangchu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCanBoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayPhanCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_reset;
    }
}
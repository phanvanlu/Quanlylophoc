namespace DOAN_QLSV
{
    partial class QuanLyDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDiem));
            this.label6 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB_Ky1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB_Ky2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XepLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_diemhocki2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_diemhocki1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_tenlop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_tenmonhoc = new System.Windows.Forms.ComboBox();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_indiem = new System.Windows.Forms.Button();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.cbxMaSV = new System.Windows.Forms.ComboBox();
            this.cbxTenSV = new System.Windows.Forms.ComboBox();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.groupBoxChucNang.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(28, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 88;
            this.label6.Text = "Mã Sinh Viên";
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
            // dtg
            // 
            this.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.HoTen,
            this.DiemTB_Ky1,
            this.DiemTB_Ky2,
            this.DiemTB,
            this.XepLoai});
            this.dtg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg.Location = new System.Drawing.Point(0, 394);
            this.dtg.Margin = new System.Windows.Forms.Padding(4);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(1310, 228);
            this.dtg.TabIndex = 87;
            this.dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellDoubleClick);
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaSV";
            this.MaHS.FillWeight = 91.37056F;
            this.MaHS.HeaderText = "Mã sinh viên";
            this.MaHS.Name = "MaHS";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.FillWeight = 101.7259F;
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // DiemTB_Ky1
            // 
            this.DiemTB_Ky1.DataPropertyName = "DiemLan1";
            this.DiemTB_Ky1.FillWeight = 101.7259F;
            this.DiemTB_Ky1.HeaderText = "Điểm lần 1";
            this.DiemTB_Ky1.Name = "DiemTB_Ky1";
            // 
            // DiemTB_Ky2
            // 
            this.DiemTB_Ky2.DataPropertyName = "DiemLan2";
            this.DiemTB_Ky2.FillWeight = 101.7259F;
            this.DiemTB_Ky2.HeaderText = "Điểm lần 2";
            this.DiemTB_Ky2.Name = "DiemTB_Ky2";
            // 
            // DiemTB
            // 
            this.DiemTB.DataPropertyName = "DiemTB";
            this.DiemTB.FillWeight = 101.7259F;
            this.DiemTB.HeaderText = "Điểm trung bình";
            this.DiemTB.Name = "DiemTB";
            // 
            // XepLoai
            // 
            this.XepLoai.DataPropertyName = "XepLoai";
            this.XepLoai.FillWeight = 101.7259F;
            this.XepLoai.HeaderText = "Xếp loại";
            this.XepLoai.Name = "XepLoai";
            // 
            // txt_diemhocki2
            // 
            this.txt_diemhocki2.Location = new System.Drawing.Point(165, 177);
            this.txt_diemhocki2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diemhocki2.Name = "txt_diemhocki2";
            this.txt_diemhocki2.Size = new System.Drawing.Size(180, 28);
            this.txt_diemhocki2.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(28, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 85;
            this.label5.Text = "Điểm Lần 2";
            // 
            // txt_diemhocki1
            // 
            this.txt_diemhocki1.Location = new System.Drawing.Point(165, 128);
            this.txt_diemhocki1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diemhocki1.Name = "txt_diemhocki1";
            this.txt_diemhocki1.Size = new System.Drawing.Size(180, 28);
            this.txt_diemhocki1.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(28, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 83;
            this.label4.Text = "Điểm Lần 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(28, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 81;
            this.label3.Text = "Tên Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tên Môn Học";
            // 
            // cbb_tenlop
            // 
            this.cbb_tenlop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_tenlop.FormattingEnabled = true;
            this.cbb_tenlop.Location = new System.Drawing.Point(109, 37);
            this.cbb_tenlop.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_tenlop.Name = "cbb_tenlop";
            this.cbb_tenlop.Size = new System.Drawing.Size(231, 28);
            this.cbb_tenlop.TabIndex = 56;
            this.cbb_tenlop.SelectedIndexChanged += new System.EventHandler(this.cbb_tenlop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 55;
            this.label1.Text = "Tên Lớp";
            // 
            // cbb_tenmonhoc
            // 
            this.cbb_tenmonhoc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_tenmonhoc.FormattingEnabled = true;
            this.cbb_tenmonhoc.Location = new System.Drawing.Point(503, 37);
            this.cbb_tenmonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_tenmonhoc.Name = "cbb_tenmonhoc";
            this.cbb_tenmonhoc.Size = new System.Drawing.Size(255, 28);
            this.cbb_tenmonhoc.TabIndex = 58;
            this.cbb_tenmonhoc.SelectedIndexChanged += new System.EventHandler(this.cbb_tenmonhoc_SelectedIndexChanged);
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.Controls.Add(this.btn_sua);
            this.groupBoxChucNang.Controls.Add(this.btn_indiem);
            this.groupBoxChucNang.Controls.Add(this.btn_nhaplai);
            this.groupBoxChucNang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChucNang.Location = new System.Drawing.Point(756, 136);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Size = new System.Drawing.Size(457, 222);
            this.groupBoxChucNang.TabIndex = 90;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Chức Năng";
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::DOAN_QLSV.Properties.Resources.icon_update;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(29, 152);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(176, 50);
            this.btn_sua.TabIndex = 67;
            this.btn_sua.Text = "Nhập Điểm";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_indiem
            // 
            this.btn_indiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_indiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_indiem.Image = global::DOAN_QLSV.Properties.Resources.icon_print;
            this.btn_indiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_indiem.Location = new System.Drawing.Point(258, 84);
            this.btn_indiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_indiem.Name = "btn_indiem";
            this.btn_indiem.Size = new System.Drawing.Size(176, 50);
            this.btn_indiem.TabIndex = 77;
            this.btn_indiem.Text = "In Bảng Điểm";
            this.btn_indiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_indiem.UseVisualStyleBackColor = true;
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nhaplai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaplai.Image = global::DOAN_QLSV.Properties.Resources.icon_import;
            this.btn_nhaplai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhaplai.Location = new System.Drawing.Point(23, 40);
            this.btn_nhaplai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(182, 50);
            this.btn_nhaplai.TabIndex = 75;
            this.btn_nhaplai.Text = "Nhập Lại";
            this.btn_nhaplai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nhaplai.UseVisualStyleBackColor = true;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.label1);
            this.groupBoxMain.Controls.Add(this.cbb_tenlop);
            this.groupBoxMain.Controls.Add(this.btn_hienthi);
            this.groupBoxMain.Controls.Add(this.label2);
            this.groupBoxMain.Controls.Add(this.cbb_tenmonhoc);
            this.groupBoxMain.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMain.Location = new System.Drawing.Point(189, 22);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(840, 87);
            this.groupBoxMain.TabIndex = 91;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Tìm Kiếm";
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthi.Image = global::DOAN_QLSV.Properties.Resources.icon_search;
            this.btn_hienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hienthi.Location = new System.Drawing.Point(785, 33);
            this.btn_hienthi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(35, 35);
            this.btn_hienthi.TabIndex = 78;
            this.btn_hienthi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hienthi.UseVisualStyleBackColor = true;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // cbxMaSV
            // 
            this.cbxMaSV.FormattingEnabled = true;
            this.cbxMaSV.Location = new System.Drawing.Point(165, 40);
            this.cbxMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMaSV.Name = "cbxMaSV";
            this.cbxMaSV.Size = new System.Drawing.Size(220, 28);
            this.cbxMaSV.TabIndex = 79;
            this.cbxMaSV.SelectedIndexChanged += new System.EventHandler(this.cbxMaSV_SelectedIndexChanged);
            // 
            // cbxTenSV
            // 
            this.cbxTenSV.FormattingEnabled = true;
            this.cbxTenSV.Location = new System.Drawing.Point(165, 84);
            this.cbxTenSV.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTenSV.Name = "cbxTenSV";
            this.cbxTenSV.Size = new System.Drawing.Size(220, 28);
            this.cbxTenSV.TabIndex = 93;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxTenSV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxMaSV);
            this.groupBox1.Controls.Add(this.txt_diemhocki2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_diemhocki1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 233);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // QuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1310, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.dtg);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyDiem";
            this.Text = "QuanLyDiem";
            this.Load += new System.EventHandler(this.QuanLyDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.groupBoxChucNang.ResumeLayout(false);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_indiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.TextBox txt_diemhocki2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_diemhocki1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_tenlop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_tenmonhoc;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.ComboBox cbxMaSV;
        private System.Windows.Forms.ComboBox cbxTenSV;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB_Ky1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB_Ky2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn XepLoai;
    }
}
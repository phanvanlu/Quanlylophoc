namespace DOAN_QLSV
{
    partial class QuanLyTrinhDo
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
            this.dgv_TrinhDo = new System.Windows.Forms.DataGridView();
            this.MaTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.txt_MaTrinhDo = new System.Windows.Forms.TextBox();
            this.label_ChuyenNganh = new System.Windows.Forms.Label();
            this.label_TenTrinhDo = new System.Windows.Forms.Label();
            this.label_MaTrinhDo = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_NhapLai = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.cmbTenTrinhDo = new System.Windows.Forms.ComboBox();
            this.cmbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TrinhDo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_TrinhDo
            // 
            this.dgv_TrinhDo.AllowUserToAddRows = false;
            this.dgv_TrinhDo.AllowUserToDeleteRows = false;
            this.dgv_TrinhDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TrinhDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TrinhDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTD,
            this.TenTD,
            this.ChuyenNganh});
            this.dgv_TrinhDo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_TrinhDo.Location = new System.Drawing.Point(0, 334);
            this.dgv_TrinhDo.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_TrinhDo.MultiSelect = false;
            this.dgv_TrinhDo.Name = "dgv_TrinhDo";
            this.dgv_TrinhDo.ReadOnly = true;
            this.dgv_TrinhDo.Size = new System.Drawing.Size(1321, 292);
            this.dgv_TrinhDo.TabIndex = 90;
            this.dgv_TrinhDo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TrinhDo_CellDoubleClick);
            // 
            // MaTD
            // 
            this.MaTD.DataPropertyName = "MaTD";
            this.MaTD.FillWeight = 55.51866F;
            this.MaTD.HeaderText = "Mã trình độ";
            this.MaTD.Name = "MaTD";
            this.MaTD.ReadOnly = true;
            // 
            // TenTD
            // 
            this.TenTD.DataPropertyName = "TenTD";
            this.TenTD.FillWeight = 76.14214F;
            this.TenTD.HeaderText = "Tên trình độ";
            this.TenTD.Name = "TenTD";
            this.TenTD.ReadOnly = true;
            // 
            // ChuyenNganh
            // 
            this.ChuyenNganh.DataPropertyName = "ChuyenNganh";
            this.ChuyenNganh.FillWeight = 168.3392F;
            this.ChuyenNganh.HeaderText = "Chuyên ngành";
            this.ChuyenNganh.Name = "ChuyenNganh";
            this.ChuyenNganh.ReadOnly = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(18, 33);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.txt_TimKiem.Multiline = true;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(199, 37);
            this.txt_TimKiem.TabIndex = 87;
            // 
            // txt_MaTrinhDo
            // 
            this.txt_MaTrinhDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_MaTrinhDo.Enabled = false;
            this.txt_MaTrinhDo.Location = new System.Drawing.Point(222, 37);
            this.txt_MaTrinhDo.Margin = new System.Windows.Forms.Padding(5);
            this.txt_MaTrinhDo.Name = "txt_MaTrinhDo";
            this.txt_MaTrinhDo.Size = new System.Drawing.Size(228, 28);
            this.txt_MaTrinhDo.TabIndex = 1;
            // 
            // label_ChuyenNganh
            // 
            this.label_ChuyenNganh.AutoSize = true;
            this.label_ChuyenNganh.ForeColor = System.Drawing.Color.Navy;
            this.label_ChuyenNganh.Location = new System.Drawing.Point(77, 130);
            this.label_ChuyenNganh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_ChuyenNganh.Name = "label_ChuyenNganh";
            this.label_ChuyenNganh.Size = new System.Drawing.Size(127, 22);
            this.label_ChuyenNganh.TabIndex = 83;
            this.label_ChuyenNganh.Text = "Chuyên ngành";
            // 
            // label_TenTrinhDo
            // 
            this.label_TenTrinhDo.AutoSize = true;
            this.label_TenTrinhDo.ForeColor = System.Drawing.Color.Navy;
            this.label_TenTrinhDo.Location = new System.Drawing.Point(77, 84);
            this.label_TenTrinhDo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_TenTrinhDo.Name = "label_TenTrinhDo";
            this.label_TenTrinhDo.Size = new System.Drawing.Size(111, 22);
            this.label_TenTrinhDo.TabIndex = 82;
            this.label_TenTrinhDo.Text = "Tên trình độ";
            // 
            // label_MaTrinhDo
            // 
            this.label_MaTrinhDo.AutoSize = true;
            this.label_MaTrinhDo.ForeColor = System.Drawing.Color.Navy;
            this.label_MaTrinhDo.Location = new System.Drawing.Point(77, 41);
            this.label_MaTrinhDo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_MaTrinhDo.Name = "label_MaTrinhDo";
            this.label_MaTrinhDo.Size = new System.Drawing.Size(107, 22);
            this.label_MaTrinhDo.TabIndex = 81;
            this.label_MaTrinhDo.Text = "Mã trình độ";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = global::DOAN_QLSV.Properties.Resources.icon_erase;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(36, 236);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(166, 42);
            this.btn_Xoa.TabIndex = 96;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Image = global::DOAN_QLSV.Properties.Resources.icon_update;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(36, 119);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(166, 42);
            this.btn_Sua.TabIndex = 94;
            this.btn_Sua.Text = "Cập nhật";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = global::DOAN_QLSV.Properties.Resources.icon_add;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(36, 30);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(166, 42);
            this.btn_Them.TabIndex = 93;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapLai.Image = global::DOAN_QLSV.Properties.Resources.icon_import;
            this.btn_NhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapLai.Location = new System.Drawing.Point(325, 33);
            this.btn_NhapLai.Margin = new System.Windows.Forms.Padding(5);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Size = new System.Drawing.Size(150, 38);
            this.btn_NhapLai.TabIndex = 91;
            this.btn_NhapLai.Text = "Nhập lại";
            this.btn_NhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhapLai.UseVisualStyleBackColor = true;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click_1);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Image = global::DOAN_QLSV.Properties.Resources.icon_search;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(217, 32);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(36, 38);
            this.btn_TimKiem.TabIndex = 88;
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // cmbTenTrinhDo
            // 
            this.cmbTenTrinhDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbTenTrinhDo.FormattingEnabled = true;
            this.cmbTenTrinhDo.Location = new System.Drawing.Point(222, 84);
            this.cmbTenTrinhDo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenTrinhDo.Name = "cmbTenTrinhDo";
            this.cmbTenTrinhDo.Size = new System.Drawing.Size(228, 28);
            this.cmbTenTrinhDo.TabIndex = 2;
            // 
            // cmbChuyenNganh
            // 
            this.cmbChuyenNganh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbChuyenNganh.FormattingEnabled = true;
            this.cmbChuyenNganh.Location = new System.Drawing.Point(222, 127);
            this.cmbChuyenNganh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChuyenNganh.Name = "cmbChuyenNganh";
            this.cmbChuyenNganh.Size = new System.Drawing.Size(228, 28);
            this.cmbChuyenNganh.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label_MaTrinhDo);
            this.groupBox1.Controls.Add(this.cmbChuyenNganh);
            this.groupBox1.Controls.Add(this.label_TenTrinhDo);
            this.groupBox1.Controls.Add(this.cmbTenTrinhDo);
            this.groupBox1.Controls.Add(this.label_ChuyenNganh);
            this.groupBox1.Controls.Add(this.txt_MaTrinhDo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(153, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 187);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(301, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 77);
            this.panel1.TabIndex = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_TimKiem);
            this.groupBox2.Controls.Add(this.btn_NhapLai);
            this.groupBox2.Controls.Add(this.btn_TimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(153, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 100);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Xoa);
            this.groupBox3.Controls.Add(this.btn_Them);
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(834, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 292);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // QuanLyTrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1321, 626);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_TrinhDo);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyTrinhDo";
            this.Text = "Chức năng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TrinhDo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_NhapLai;
        private System.Windows.Forms.DataGridView dgv_TrinhDo;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.TextBox txt_MaTrinhDo;
        private System.Windows.Forms.Label label_ChuyenNganh;
        private System.Windows.Forms.Label label_TenTrinhDo;
        private System.Windows.Forms.Label label_MaTrinhDo;
        private System.Windows.Forms.ComboBox cmbTenTrinhDo;
        private System.Windows.Forms.ComboBox cmbChuyenNganh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenNganh;
    }
}


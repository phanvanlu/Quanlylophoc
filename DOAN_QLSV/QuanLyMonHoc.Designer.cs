namespace DOAN_QLSV
{
    partial class QuanLyMonHoc
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
            this.dgv_MonHoc = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_NhapLai = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.txt_SoTiet = new System.Windows.Forms.TextBox();
            this.txt_TenMonHoc = new System.Windows.Forms.TextBox();
            this.txt_MaMoHoc = new System.Windows.Forms.TextBox();
            this.label_SoTiet = new System.Windows.Forms.Label();
            this.label_TenMonHoc = new System.Windows.Forms.Label();
            this.label_MaMonHoc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_MonHoc
            // 
            this.dgv_MonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.SoTiet});
            this.dgv_MonHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_MonHoc.Location = new System.Drawing.Point(0, 300);
            this.dgv_MonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_MonHoc.Name = "dgv_MonHoc";
            this.dgv_MonHoc.Size = new System.Drawing.Size(1302, 341);
            this.dgv_MonHoc.TabIndex = 93;
            this.dgv_MonHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MonHoc_CellDoubleClick);
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã môn học";
            this.MaMH.Name = "MaMH";
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên môn học";
            this.TenMH.Name = "TenMH";
            // 
            // SoTiet
            // 
            this.SoTiet.DataPropertyName = "SoTiet";
            this.SoTiet.HeaderText = "Số tiết";
            this.SoTiet.Name = "SoTiet";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Image = global::DOAN_QLSV.Properties.Resources.icon_search;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(402, 29);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(36, 31);
            this.btn_TimKiem.TabIndex = 91;
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = global::DOAN_QLSV.Properties.Resources.icon_erase;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(293, 161);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(145, 37);
            this.btn_Xoa.TabIndex = 90;
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
            this.btn_Sua.Location = new System.Drawing.Point(27, 161);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(188, 38);
            this.btn_Sua.TabIndex = 88;
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
            this.btn_Them.Location = new System.Drawing.Point(293, 91);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(145, 37);
            this.btn_Them.TabIndex = 87;
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
            this.btn_NhapLai.Location = new System.Drawing.Point(27, 90);
            this.btn_NhapLai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Size = new System.Drawing.Size(188, 37);
            this.btn_NhapLai.TabIndex = 85;
            this.btn_NhapLai.Text = "Nhập lại";
            this.btn_NhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhapLai.UseVisualStyleBackColor = true;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(21, 30);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Multiline = true;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(373, 30);
            this.txt_TimKiem.TabIndex = 84;
            // 
            // txt_SoTiet
            // 
            this.txt_SoTiet.Location = new System.Drawing.Point(205, 157);
            this.txt_SoTiet.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoTiet.Name = "txt_SoTiet";
            this.txt_SoTiet.Size = new System.Drawing.Size(262, 28);
            this.txt_SoTiet.TabIndex = 3;
            // 
            // txt_TenMonHoc
            // 
            this.txt_TenMonHoc.Location = new System.Drawing.Point(205, 99);
            this.txt_TenMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenMonHoc.Name = "txt_TenMonHoc";
            this.txt_TenMonHoc.Size = new System.Drawing.Size(262, 28);
            this.txt_TenMonHoc.TabIndex = 2;
            // 
            // txt_MaMoHoc
            // 
            this.txt_MaMoHoc.Enabled = false;
            this.txt_MaMoHoc.Location = new System.Drawing.Point(205, 42);
            this.txt_MaMoHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaMoHoc.Name = "txt_MaMoHoc";
            this.txt_MaMoHoc.Size = new System.Drawing.Size(262, 28);
            this.txt_MaMoHoc.TabIndex = 1;
            // 
            // label_SoTiet
            // 
            this.label_SoTiet.AutoSize = true;
            this.label_SoTiet.Location = new System.Drawing.Point(28, 157);
            this.label_SoTiet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SoTiet.Name = "label_SoTiet";
            this.label_SoTiet.Size = new System.Drawing.Size(62, 22);
            this.label_SoTiet.TabIndex = 80;
            this.label_SoTiet.Text = "Số tiết";
            // 
            // label_TenMonHoc
            // 
            this.label_TenMonHoc.AutoSize = true;
            this.label_TenMonHoc.Location = new System.Drawing.Point(28, 99);
            this.label_TenMonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenMonHoc.Name = "label_TenMonHoc";
            this.label_TenMonHoc.Size = new System.Drawing.Size(116, 22);
            this.label_TenMonHoc.TabIndex = 79;
            this.label_TenMonHoc.Text = "Tên môn học";
            // 
            // label_MaMonHoc
            // 
            this.label_MaMonHoc.AutoSize = true;
            this.label_MaMonHoc.Location = new System.Drawing.Point(28, 42);
            this.label_MaMonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaMonHoc.Name = "label_MaMonHoc";
            this.label_MaMonHoc.Size = new System.Drawing.Size(112, 22);
            this.label_MaMonHoc.TabIndex = 78;
            this.label_MaMonHoc.Text = "Mã môn học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_MaMonHoc);
            this.groupBox1.Controls.Add(this.label_TenMonHoc);
            this.groupBox1.Controls.Add(this.label_SoTiet);
            this.groupBox1.Controls.Add(this.txt_MaMoHoc);
            this.groupBox1.Controls.Add(this.txt_TenMonHoc);
            this.groupBox1.Controls.Add(this.txt_SoTiet);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(102, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 234);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_TimKiem);
            this.groupBox2.Controls.Add(this.btn_TimKiem);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_NhapLai);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(661, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 234);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1302, 641);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_MonHoc);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyMonHoc";
            this.Text = "QuanLyMonHoc";
            this.Load += new System.EventHandler(this.QuanLyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTiet;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_NhapLai;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.TextBox txt_SoTiet;
        private System.Windows.Forms.TextBox txt_TenMonHoc;
        private System.Windows.Forms.TextBox txt_MaMoHoc;
        private System.Windows.Forms.Label label_SoTiet;
        private System.Windows.Forms.Label label_TenMonHoc;
        private System.Windows.Forms.Label label_MaMonHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
namespace DOAN_QLSV
{
    partial class DangNhap
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
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label_MatKhau = new System.Windows.Forms.Label();
            this.label_TaiKhoan = new System.Windows.Forms.Label();
            this.label_DangNhap = new System.Windows.Forms.Label();
            this.chkHienThi = new System.Windows.Forms.CheckBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(278, 263);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(315, 28);
            this.txt_MatKhau.TabIndex = 11;
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Location = new System.Drawing.Point(278, 165);
            this.txt_TaiKhoan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(315, 28);
            this.txt_TaiKhoan.TabIndex = 10;
            // 
            // label_MatKhau
            // 
            this.label_MatKhau.AutoSize = true;
            this.label_MatKhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MatKhau.ForeColor = System.Drawing.Color.Navy;
            this.label_MatKhau.Location = new System.Drawing.Point(156, 268);
            this.label_MatKhau.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_MatKhau.Name = "label_MatKhau";
            this.label_MatKhau.Size = new System.Drawing.Size(100, 22);
            this.label_MatKhau.TabIndex = 15;
            this.label_MatKhau.Text = "Mật khẩu :";
            // 
            // label_TaiKhoan
            // 
            this.label_TaiKhoan.AutoSize = true;
            this.label_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TaiKhoan.ForeColor = System.Drawing.Color.Navy;
            this.label_TaiKhoan.Location = new System.Drawing.Point(156, 176);
            this.label_TaiKhoan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_TaiKhoan.Name = "label_TaiKhoan";
            this.label_TaiKhoan.Size = new System.Drawing.Size(104, 22);
            this.label_TaiKhoan.TabIndex = 16;
            this.label_TaiKhoan.Text = "Tài khoản :";
            // 
            // label_DangNhap
            // 
            this.label_DangNhap.AutoSize = true;
            this.label_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_DangNhap.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_DangNhap.Location = new System.Drawing.Point(204, 63);
            this.label_DangNhap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_DangNhap.Name = "label_DangNhap";
            this.label_DangNhap.Size = new System.Drawing.Size(389, 68);
            this.label_DangNhap.TabIndex = 14;
            this.label_DangNhap.Text = "ĐĂNG NHẬP";
            // 
            // chkHienThi
            // 
            this.chkHienThi.AutoSize = true;
            this.chkHienThi.Location = new System.Drawing.Point(278, 321);
            this.chkHienThi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHienThi.Name = "chkHienThi";
            this.chkHienThi.Size = new System.Drawing.Size(191, 26);
            this.chkHienThi.TabIndex = 17;
            this.chkHienThi.Text = "Hiển Thị Mật Khẩu";
            this.chkHienThi.UseVisualStyleBackColor = true;
            this.chkHienThi.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Image = global::DOAN_QLSV.Properties.Resources.icon_cancell;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(459, 400);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(167, 51);
            this.btn_Thoat.TabIndex = 13;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Image = global::DOAN_QLSV.Properties.Resources.icon_login;
            this.btn_DangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangNhap.Location = new System.Drawing.Point(160, 400);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(167, 51);
            this.btn_DangNhap.TabIndex = 12;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(795, 514);
            this.Controls.Add(this.chkHienThi);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.label_MatKhau);
            this.Controls.Add(this.label_TaiKhoan);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.label_DangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label label_MatKhau;
        private System.Windows.Forms.Label label_TaiKhoan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label label_DangNhap;
        private System.Windows.Forms.CheckBox chkHienThi;
    }
}
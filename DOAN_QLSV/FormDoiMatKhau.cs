using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DOAN_QLSV
{
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }
        BUS_UC0_DoiMatKhau BUS_doiMK = new BUS_UC0_DoiMatKhau();
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            string mk = DangNhap.matkhau;
            string tk = DangNhap.taikhoan;
            if (txt_MatKhauCu.Text.Length == 0 || txt_MatKhauMoi.Text.Length == 0 || txt_XacNhanMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải điền toàn bộ các ô", "Đổi mật khẩu không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_MatKhauCu.Text != mk)
            {
                MessageBox.Show("Mật khẩu của bạn không chính xác. Hãy kiểm tra lại!", "Đổi mật khẩu không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_MatKhauMoi.Text != txt_XacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp. Hãy kiểm tra lại!", "Đổi mật khẩu không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BUS_doiMK.DoiMatKhau(tk, txt_MatKhauMoi.Text);
            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
            DangNhap.matkhau = txt_MatKhauMoi.Text;
            txt_MatKhauCu.Clear();
            txt_MatKhauMoi.Clear();
            txt_XacNhanMatKhau.Clear();
            txt_MatKhauCu.Focus();
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void label_MatKhauMoi_Click(object sender, EventArgs e)
        {

        }

        private void label_MatKhau_Click(object sender, EventArgs e)
        {

        }

        private void radHienThiMatKhauCu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radHienThiMatKhauCu.Checked == true)
            {
                txt_MatKhauCu.PasswordChar = (char)0;
            }
            else
            {
                txt_MatKhauCu.PasswordChar = '*';
            }
        }

        private void radHienThiMatKhauMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radHienThiMatKhauMoi.Checked == true)
            {
                txt_MatKhauMoi.PasswordChar = (char)0;
            }
            else
            {
                txt_MatKhauMoi.PasswordChar = '*';
            }
        }

        private void radNhapLaiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radNhapLaiMatKhau.Checked == true)
            {
                txt_XacNhanMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txt_XacNhanMatKhau.PasswordChar = '*';
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
                this.Close();
        }
    }
}

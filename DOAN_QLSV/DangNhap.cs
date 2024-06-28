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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        BUS_UC0_DangNhap bus_dangnhap = new BUS_UC0_DangNhap();
        public static bool isAdmin;
        public static string hoTenCBGV;
        public static string taikhoan;
        public static string matkhau;
        private void DangNhap_Load(object sender, EventArgs e)
        {
            txt_TaiKhoan.Focus();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản không được bỏ trống", "Đăng nhập không thành công");
                return;
            }

            if (txt_MatKhau.Text.Length == 0)
            {
                MessageBox.Show("Mật khẩu không được bỏ trống", "Đăng nhập không thành công");
                return;
            }
            if (!bus_dangnhap.checkLogin(txt_TaiKhoan.Text, txt_MatKhau.Text))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Đăng nhập không thành công");
                return;
            }
            if (!bus_dangnhap.isAdmin(txt_TaiKhoan.Text, txt_MatKhau.Text))
                isAdmin = false;
            else isAdmin = true;
            //hoTenCBGV = bus_dangnhap.getHoTenCBGV(txt_TaiKhoan.Text, txt_MatKhau.Text);
            MessageBox.Show("Chào mừng ID: " + txt_TaiKhoan.Text + " đến với hệ thống !");
            taikhoan = txt_TaiKhoan.Text;
            matkhau = txt_MatKhau.Text;
            Form form_TrangChu = new form_TrangChu();
            this.Hide();
            form_TrangChu.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkHienThi.Checked == true)
            {
                txt_MatKhau.PasswordChar = (char)0;
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}

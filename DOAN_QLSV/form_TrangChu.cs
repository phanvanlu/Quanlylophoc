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
    public partial class form_TrangChu : Form
    {
        public form_TrangChu()
        {
            InitializeComponent();
        }

        private void dangnhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDanhSach.Controls.Clear();
        }

        private void form_TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            panelDanhSach.Controls.Clear();
            btnThongTin.Text = "SINH VIÊN";
            groupBoxThongTin.Text = "Thông Tin Sinh Viên";
            QuanLySinhVien item_quanlysv = new QuanLySinhVien();
            item_quanlysv.TopLevel = false;
            panelDanhSach.Controls.Add(item_quanlysv);
            item_quanlysv.Show();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            panelDanhSach.Controls.Clear();
            btnThongTin.Text = "GIÁO VIÊN";
            groupBoxThongTin.Text = "Thông Tin Giáo Viên";
            QuanLyGiaoVien item_quanlygv = new QuanLyGiaoVien();
            item_quanlygv.TopLevel = false;
            panelDanhSach.Controls.Add(item_quanlygv);
            item_quanlygv.Show();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            panelDanhSach.Controls.Clear();
            btnThongTin.Text = "LỚP";
            groupBoxThongTin.Text = "Thông Tin Lớp";
            QuanLyLopHoc item_quanlop = new QuanLyLopHoc();
            item_quanlop.TopLevel = false;
            panelDanhSach.Controls.Add(item_quanlop);
            item_quanlop.Show();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            panelDanhSach.Controls.Clear();
            btnThongTin.Text = "MÔN HỌC";
            groupBoxThongTin.Text = "Thông Tin Môn Học";
            QuanLyMonHoc item_quanmohoc = new QuanLyMonHoc();
            item_quanmohoc.TopLevel = false;
            panelDanhSach.Controls.Add(item_quanmohoc);
            item_quanmohoc.Show();
        }

        private void btnTrinhDo_Click(object sender, EventArgs e)
        {
            panelDanhSach.Controls.Clear();
            btnThongTin.Text = "TRÌNH ĐỘ";
            groupBoxThongTin.Text = "Thông Tin Trình Độ";
            QuanLyTrinhDo item_quantrinhdo = new QuanLyTrinhDo();
            item_quantrinhdo.TopLevel = false;
            panelDanhSach.Controls.Add(item_quantrinhdo);
            item_quantrinhdo.Show();
        }

        private void btnLichHoc_Click(object sender, EventArgs e)
        {
            panelDanhSach.Controls.Clear();
            btnThongTin.Text = "LỊCH HỌC";
            groupBoxThongTin.Text = "Thông Tin Lịch Học";
            QuanLyLichHoc item_quanlichhoc = new QuanLyLichHoc();
            item_quanlichhoc.TopLevel = false;
            panelDanhSach.Controls.Add(item_quanlichhoc);
            item_quanlichhoc.Show();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            panelDanhSach.Controls.Clear();
            btnThongTin.Text = "ĐIỂM";
            groupBoxThongTin.Text = "Thông Tin Điểm";
            QuanLyDiem item_quandiem = new QuanLyDiem();
            item_quandiem.TopLevel = false;
            panelDanhSach.Controls.Add(item_quandiem);
            item_quandiem.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void danhSáchSinhViênMộtLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachSinhVien1Lop frm = new DanhSachSinhVien1Lop();
            frm.Show();
          
        }

        private void danhSáchGiáoViênMộtLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachGiaoVien1Lop frm = new DanhSachGiaoVien1Lop();
            frm.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau frm = new FormDoiMatKhau();
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlr == DialogResult.Yes)
            {
                Form frm = new DangNhap();
                DangNhap.taikhoan = null;
                DangNhap.matkhau = null;
                //DangNhap.hoTenCBGV = null;
                this.Close();
                frm.Show();
            }
        }
    }
}

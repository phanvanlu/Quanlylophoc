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
    public partial class DanhSachSinhVien1Lop : Form
    {
        public DanhSachSinhVien1Lop()
        {
            InitializeComponent();
        }
        BUS_UC4_DanhSachSinhVien1Lop danhsachhocsinh1loph = new BUS_UC4_DanhSachSinhVien1Lop();
        private void DanhSachSinhVien1Lop_Load(object sender, EventArgs e)
        {
            cbb_tenlop.DataSource = danhsachhocsinh1loph.ShowTenLopHoc();
            cbb_tenlop.DisplayMember = "TenLop";
            cbb_tenlop.ValueMember = "MaLop";

            cbb_tenlop.Enabled = true;
            cbb_nienkhoa.Enabled = false;
            cbb_siso.Enabled = false;
            cbb_giaovienchunhiem.Enabled = false;
            dtg.Enabled = false;
            //btn_indshs1lop.Enabled = false;
            btn_hienthidanhsachhocsinh.Enabled = true;
        }

        private void cbb_tenlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_nienkhoa.DataSource = danhsachhocsinh1loph.ShowNienKhoa(cbb_tenlop.SelectedValue.ToString());
            cbb_nienkhoa.DisplayMember = "NienKhoa";
            cbb_nienkhoa.ValueMember = "NienKhoa";

            cbb_siso.DataSource = danhsachhocsinh1loph.ShowSiSo(cbb_tenlop.SelectedValue.ToString());
            cbb_siso.DisplayMember = "SiSo";
            cbb_siso.ValueMember = "SiSo";

            cbb_giaovienchunhiem.DataSource = danhsachhocsinh1loph.ShowGiaoVienChuNhiem(cbb_tenlop.SelectedValue.ToString());
            cbb_giaovienchunhiem.DisplayMember = "GiaoVienChuNhiem";
            cbb_giaovienchunhiem.ValueMember = "GiaoVienChuNhiem";
        }

        private void btn_hienthidanhsachhocsinh_Click(object sender, EventArgs e)
        {
            dtg.Enabled = true;
            cbb_tenlop.Enabled = false;
            dtg.DataSource = danhsachhocsinh1loph.ShowDanhSachHocSinh(cbb_tenlop.SelectedValue.ToString());
            btn_indshs1lop.Enabled = true;
            btn_hienthidanhsachhocsinh.Enabled = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DanhSachSinhVien1Lop_Load(sender, e);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("DANH SÁCH HỌC SINH TRONG MỘT LỚP", new Font("Times New Roman", 24, FontStyle.Bold), Brushes.Black, new PointF(110, 80));


            e.Graphics.DrawString("Tên Lớp Học:", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(190, 140));
            e.Graphics.DrawString(cbb_tenlop.Text, new Font("Times New Roman", 18, FontStyle.Italic), Brushes.Black, new PointF(450, 140));


            e.Graphics.DrawString("Niên Khóa:", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(190, 170));
            e.Graphics.DrawString(cbb_nienkhoa.Text, new Font("Times New Roman", 18, FontStyle.Italic), Brushes.Black, new PointF(450, 170));

            e.Graphics.DrawString("Sĩ Số:", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(190, 200));
            e.Graphics.DrawString(cbb_siso.Text, new Font("Times New Roman", 18, FontStyle.Italic), Brushes.Black, new PointF(450, 200));

            e.Graphics.DrawString("Giáo Viên Chủ Nhiệm:", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(190, 230));
            e.Graphics.DrawString(cbb_giaovienchunhiem.Text, new Font("Times New Roman", 18, FontStyle.Italic), Brushes.Black, new PointF(450, 230));

            Bitmap bm = new Bitmap(this.dtg.Width, this.dtg.Height);
            dtg.DrawToBitmap(bm, new Rectangle(0, 0, this.dtg.Width, this.dtg.Height));
            e.Graphics.DrawImage(bm, 0, 330);

            e.Graphics.DrawString("Người Lập Phiếu", new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new PointF(565, 600));
            e.Graphics.DrawString("Mạnh", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 640));
            e.Graphics.DrawString("Nguyễn Ngọc Mạnh", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(550, 680));
        }

        private void btn_indshs1lop_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void btn_trovetrangchu_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
                this.Close();
        }
    }
}

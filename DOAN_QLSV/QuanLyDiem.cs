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
    public partial class QuanLyDiem : Form
    {
        public QuanLyDiem()
        {
            InitializeComponent();
        }
        BUS_UC2_ThemSuaXemInDiem themsuaxemindiemh = new BUS_UC2_ThemSuaXemInDiem();
        private void QuanLyDiem_Load(object sender, EventArgs e)
        {
            cbb_tenlop.DataSource = themsuaxemindiemh.ShowTenLop();
            cbb_tenlop.DisplayMember = "TenLop";
            cbb_tenlop.ValueMember = "MaLop";

            /*cbb_tenmonhoc.DataSource = themsuaxemindiemh.ShowTenMon();
            cbb_tenmonhoc.DisplayMember = "TenMH";
            cbb_tenmonhoc.ValueMember = "MaMH";*/
            txt_diemhocki1.Enabled = false;
            txt_diemhocki2.Enabled = false;
            
            this.groupBoxChucNang.Enabled = false;
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            dtg.DataSource = themsuaxemindiemh.ShowDiem(cbb_tenlop.SelectedValue.ToString(), cbb_tenmonhoc.SelectedValue.ToString());
            
            cbxMaSV.DataSource = themsuaxemindiemh.ShowMaSV(cbb_tenmonhoc.SelectedValue.ToString());
            cbxMaSV.DisplayMember = "MaSV";
            cbxMaSV.ValueMember = "MaSV";

            cbxMaSV.Enabled = true;
            cbxTenSV.Enabled = true;
            txt_diemhocki1.Enabled = true;
            txt_diemhocki2.Enabled = true;
            this.groupBoxMain.Enabled = false;
            this.groupBoxChucNang.Enabled = true;

            
        }
        private void dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            cbxMaSV.Text = dtg.Rows[dong].Cells[0].Value.ToString();
            cbxTenSV.Text = dtg.Rows[dong].Cells[1].Value.ToString();
            txt_diemhocki1.Text = dtg.Rows[dong].Cells[2].Value.ToString();
            txt_diemhocki2.Text = dtg.Rows[dong].Cells[3].Value.ToString();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_diemhocki1.Clear();
            txt_diemhocki2.Clear();
            cbb_tenlop.Text = "";
            cbb_tenmonhoc.Text = "";

            this.groupBoxMain.Enabled = true;
            this.groupBoxChucNang.Enabled = false;

            cbxMaSV.Enabled = false;
            cbxTenSV.Enabled = false;
            txt_diemhocki1.Enabled = false;
            txt_diemhocki2.Enabled = false;
        }

        /*private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_diemhocki1.Text == "")
                MessageBox.Show("Bạn chưa nhập điểm");
            else if (txt_diemhocki2.Text == "")
                MessageBox.Show("Bạn chưa nhập điểm");
            else
            {
                try
                {
                    string masinhvien = cbxMaSV.Text;
                    string tensinhvien = cbxTenSV.Text;
                    string mamonhoc = cbb_tenmonhoc.SelectedValue.ToString();
                    string tenmonhoc = cbb_tenmonhoc.Text;
                    float diemlan1 = float.Parse(txt_diemhocki1.Text);
                    float diemlan2 = float.Parse(txt_diemhocki2.Text);

                    themsuaxemindiemh.InsertDiem(masinhvien,tensinhvien,mamonhoc, tenmonhoc,diemlan1,diemlan2);

                    MessageBox.Show("Thêm thành công!");
                    dtg.DataSource = themsuaxemindiemh.ShowDiem(cbb_tenlop.SelectedValue.ToString(), cbb_tenmonhoc.SelectedValue.ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi!" + ex.Message);
                }
            }
        }*/
        private void cbxMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxTenSV.DataSource = themsuaxemindiemh.ShowTenSV(cbxMaSV.SelectedValue.ToString());
            cbxTenSV.DisplayMember = "HoTen";
            cbxTenSV.ValueMember = "HoTen";
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_diemhocki1.TextLength == 0)
                MessageBox.Show("Điểm học kì 1 không được để trống!");
            else if (txt_diemhocki2.TextLength == 0)
                MessageBox.Show("Điểm học kì 2 không được để trống!");
            else
            {
                try
                {
                    string masinhvien = cbxMaSV.Text;
                    string tensinhvien = cbxTenSV.Text;
                    string mamonhoc = cbb_tenmonhoc.SelectedValue.ToString();
                    string malop = cbb_tenlop.SelectedValue.ToString();
                    string tenmonhoc = cbb_tenmonhoc.Text;
                    float diemlan1 = float.Parse(txt_diemhocki1.Text);
                    float diemlan2 = float.Parse(txt_diemhocki2.Text);


                    themsuaxemindiemh.UpdateDiem(masinhvien,tensinhvien,mamonhoc,tenmonhoc,diemlan1,diemlan2);
                    MessageBox.Show("Nhập điểm thành công! ");
                    dtg.DataSource = themsuaxemindiemh.ShowDiem(malop, mamonhoc);
                }
                catch { MessageBox.Show("Có lỗi!"); }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("DANH SÁCH ĐIỂM HỌC SINH", new Font("Times New Roman", 24, FontStyle.Regular), Brushes.Black, new PointF(210, 80));
            e.Graphics.DrawString("Tên Lớp:", new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new PointF(200, 140));
            e.Graphics.DrawString(cbb_tenlop.Text, new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new PointF(400, 140));
            e.Graphics.DrawString("Tên Môn Học:", new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new PointF(200, 170));
            e.Graphics.DrawString(cbb_tenmonhoc.Text, new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new PointF(400, 170));

            Bitmap bm = new Bitmap(this.dtg.Width, this.dtg.Height);
            dtg.DrawToBitmap(bm, new Rectangle(0, 0, this.dtg.Width, this.dtg.Height));
            e.Graphics.DrawImage(bm, 60, 300);

            e.Graphics.DrawString("Người Lập Phiếu", new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new PointF(565, 600));
            e.Graphics.DrawString("Mạnh", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 640));
            e.Graphics.DrawString("Nguyễn Ngọc Mạnh", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(550, 680));
        }

        private void cbb_tenlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_tenmonhoc.DataSource = themsuaxemindiemh.ShowTenMon(cbb_tenlop.SelectedValue.ToString());
            cbb_tenmonhoc.DisplayMember = "TenMH";
            cbb_tenmonhoc.ValueMember = "MaMH";
        }

        private void cbb_tenmonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        
    }
}

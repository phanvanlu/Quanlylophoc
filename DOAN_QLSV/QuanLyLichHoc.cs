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
    public partial class QuanLyLichHoc : Form
    {
        public QuanLyLichHoc()
        {
            InitializeComponent();
        }
        BUS_UC3_LichHoc phanconglichhoch = new BUS_UC3_LichHoc();
        private void QuanLyLichHoc_Load(object sender, EventArgs e)
        {
            cbb_tenlophoc.DataSource = phanconglichhoch.ShowTenLopHoc();
            cbb_tenlophoc.DisplayMember = "TenLop";
            cbb_tenlophoc.ValueMember = "MaLop";

            cbb_tenmonhoc.DataSource = phanconglichhoch.ShowTenMonHoc();
            cbb_tenmonhoc.DisplayMember = "TenMH";
            cbb_tenmonhoc.ValueMember = "MaMH";

            cbb_tengiaovien.DataSource = phanconglichhoch.ShowTenCBGV();
            cbb_tengiaovien.DisplayMember = "HoTen";
            cbb_tengiaovien.ValueMember = "MaGiaoVien";

            this.groupBoxPCGD.Enabled = false;
            this.groupboxXemPCGD.Enabled = false;
            this.dtg.Enabled = false;

            cbb_tenlophoc2.DataSource = phanconglichhoch.ShowTenLopHoc();
            cbb_tenlophoc2.DisplayMember = "TenLop";
            cbb_tenlophoc2.ValueMember = "MaLop";

            cbb_tenmonhoc2.DataSource = phanconglichhoch.ShowTenMonHoc();
            cbb_tenmonhoc2.DisplayMember = "TenMH";
            cbb_tenmonhoc2.ValueMember = "MaMH";

            cbb_tengiaovien2.DataSource = phanconglichhoch.ShowTenCBGV();
            cbb_tengiaovien2.DisplayMember = "HoTen";
            cbb_tengiaovien2.ValueMember = "MaGiaoVien";

            this.cbb_tenlophoc2.Enabled = false;
            this.cbb_tenmonhoc2.Enabled = false;
            this.cbb_tengiaovien2.Enabled = false;

            this.rb_PhanCongLichHoc.Checked = false;
            this.rb_XemInLichHoc.Checked = false;
            this.cbb_tenlophoc2.Enabled = false;
            this.cbb_tenmonhoc2.Enabled = false;
            this.cbb_tengiaovien2.Enabled = false;
        }

        private void rb_PhanCongLichHoc_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxPCGD.Enabled = true;
            this.groupboxXemPCGD.Enabled = false;
            this.dtg.Enabled = true;
            dtg.DataSource = phanconglichhoch.ShowPCGD();
        }

        private void rb_XemInLichHoc_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxPCGD.Enabled = false;
            this.groupboxXemPCGD.Enabled = true;
            this.dtg.Enabled = true;
            txtPhongHoc.Clear();
            txtGioBD.Clear();
            txtGioKT.Clear();
        }

        private void dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;

            if (this.groupBoxPCGD.Enabled == true)
            {
                cbb_tenlophoc.Text = dtg.Rows[dong].Cells[0].Value.ToString();
                cbb_tenmonhoc.Text = dtg.Rows[dong].Cells[1].Value.ToString();
                cbb_tengiaovien.Text = dtg.Rows[dong].Cells[2].Value.ToString();
                txtPhongHoc.Text = dtg.Rows[dong].Cells[3].Value.ToString();
                dtNgayHoc.Text = dtg.Rows[dong].Cells[4].Value.ToString();
                txtGioBD.Text = dtg.Rows[dong].Cells[5].Value.ToString();
                txtGioKT.Text = dtg.Rows[dong].Cells[6].Value.ToString();
            }
        }

        private void rad_tenlophoc_CheckedChanged(object sender, EventArgs e)
        {
            this.cbb_tenlophoc2.Enabled = true;
            this.cbb_tenmonhoc2.Enabled = false;
            this.cbb_tengiaovien2.Enabled = false;
        }

        private void rad_tenmonhoc_CheckedChanged(object sender, EventArgs e)
        {
            this.cbb_tenlophoc2.Enabled = false;
            this.cbb_tenmonhoc2.Enabled = true;
            this.cbb_tengiaovien2.Enabled = false;
        }

        private void rad_tengiaovien_CheckedChanged(object sender, EventArgs e)
        {
            this.cbb_tenlophoc2.Enabled = false;
            this.cbb_tenmonhoc2.Enabled = false;
            this.cbb_tengiaovien2.Enabled = true;
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            this.dtg.Enabled = true;
            string malop = cbb_tenlophoc2.SelectedValue.ToString();
            string mamonhoc = cbb_tenmonhoc2.SelectedValue.ToString();
            string magiaovien = cbb_tengiaovien2.SelectedValue.ToString();
            if (rad_tenlophoc.Checked)
                dtg.DataSource = phanconglichhoch.LookXemPhanCongGiangDayThemMaLop(malop);
            if (rad_tenmonhoc.Checked)
                dtg.DataSource = phanconglichhoch.LookXemPhanCongGiangDayThemMonHoc(mamonhoc);
            if (rad_tengiaovien.Checked)
                dtg.DataSource = phanconglichhoch.LookXemPhanCongGiangDayThemGiaoVien(magiaovien);
        }

        private void btn_trovetrangchu_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btn_themphancong_Click(object sender, EventArgs e)
        {
            if (cbb_tenlophoc.Text == "")
                MessageBox.Show("Chưa có lớp học");
            else if (cbb_tenmonhoc.Text == "")
                MessageBox.Show("Chưa có môn học");
            else if (cbb_tengiaovien.Text == "")
                MessageBox.Show("Chưa có giáo viên");
            else if (txtPhongHoc.Text == "")
                MessageBox.Show("Chưa có phòng học");
            else if (txtGioBD.Text == "")
                MessageBox.Show("Chưa có giờ học");
            else if (txtGioKT.Text == "")
                MessageBox.Show("Chưa có giờ kết thúc");
            else
            {
                try
                {
                    string malop = cbb_tenlophoc.SelectedValue.ToString();
                    string tenlop = cbb_tenlophoc.Text;
                    string mamon = cbb_tenmonhoc.SelectedValue.ToString();
                    string tenmon = cbb_tenmonhoc.Text;
                    string magiaovien = cbb_tengiaovien.SelectedValue.ToString();
                    string tengiaovien = cbb_tengiaovien.Text;
                    string ngayhoc = dtNgayHoc.Value.ToString("yyyy-MM-dd");
                    int phonghoc = Int32.Parse(txtPhongHoc.Text);
                    string giobd = txtGioBD.Text;
                    string giokt = txtGioKT.Text;

                    phanconglichhoch.InsertPhanCongGiangDay(malop,tenlop,mamon,tenmon,magiaovien,tengiaovien,phonghoc,ngayhoc,giobd,giokt);

                    MessageBox.Show("Thêm thành công!");
                    dtg.DataSource = phanconglichhoch.ShowPCGD();
                    txtPhongHoc.Clear();
                    txtGioBD.Clear();
                    txtGioKT.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi!" + ex.Message);
                }
            }
        }

        private void btn_suaphancong_Click(object sender, EventArgs e)
        {
            if (cbb_tenlophoc.Text == "")
                MessageBox.Show("Chưa có lớp học");
            else if (cbb_tenmonhoc.Text == "")
                MessageBox.Show("Chưa có môn học");
            else if (cbb_tengiaovien.Text == "")
                MessageBox.Show("Chưa có giáo viên");
            else if (txtPhongHoc.Text == "")
                MessageBox.Show("Chưa có phòng học");
            else if (txtGioBD.Text == "")
                MessageBox.Show("Chưa có giờ học");
            else if (txtGioKT.Text == "")
                MessageBox.Show("Chưa có giờ kết thúc");
            else
            {
                try
                {
                    string malop = cbb_tenlophoc.SelectedValue.ToString();
                    string tenlop = cbb_tenlophoc.Text;
                    string mamon = cbb_tenmonhoc.SelectedValue.ToString();
                    string tenmon = cbb_tenmonhoc.Text;
                    string magiaovien = cbb_tengiaovien.SelectedValue.ToString();
                    string tengiaovien = cbb_tengiaovien.Text;
                    string ngayhoc = dtNgayHoc.Value.ToString("yyyy-MM-dd");
                    int phonghoc = Int32.Parse(txtPhongHoc.Text);
                    string giobd = txtGioBD.Text;
                    string giokt = txtGioKT.Text;

                    phanconglichhoch.UpdatePhanCongGiangDay(malop, tenlop, mamon, tenmon, magiaovien, tengiaovien, phonghoc , ngayhoc, giobd, giokt);

                    MessageBox.Show("Sửa thành công!");
                    dtg.DataSource = phanconglichhoch.ShowPCGD();
                    txtPhongHoc.Clear();
                    txtGioBD.Clear();
                    txtGioKT.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi!" + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbb_tenlophoc.Text == "")
                MessageBox.Show("Chưa có lớp học");
            else if (cbb_tenmonhoc.Text == "")
                MessageBox.Show("Chưa có môn học");
            else if (cbb_tengiaovien.Text == "")
                MessageBox.Show("Chưa có giáo viên");
            else if (txtPhongHoc.Text == "")
                MessageBox.Show("Chưa có phòng học");
            else if (txtGioBD.Text == "")
                MessageBox.Show("Chưa có giờ học");
            else if (txtGioKT.Text == "")
                MessageBox.Show("Chưa có giờ kết thúc");
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn chắc chắn muốn Xoá ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    string malop = cbb_tenlophoc.SelectedValue.ToString();
                    string mamon = cbb_tenmonhoc.SelectedValue.ToString();
                    string magiaovien = cbb_tengiaovien.SelectedValue.ToString();

                    phanconglichhoch.DeletePhanCongGiangDay(malop,mamon,magiaovien);
                    MessageBox.Show("Đã Xóa Thành Công");
                    dtg.DataSource = phanconglichhoch.ShowPCGD();
                    txtPhongHoc.Clear();
                    txtGioBD.Clear();
                    txtGioKT.Clear();
                }
            }
        }

        private void btn_inbangphancong_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }




    }
}

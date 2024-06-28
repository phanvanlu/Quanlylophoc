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
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }
        BUS_UC1_QuanLyMonHoc monhoch = new BUS_UC1_QuanLyMonHoc();
        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            dgv_MonHoc.DataSource = monhoch.ShowMonHoc();
        }

        private void dgv_MonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_MaMoHoc.Text = dgv_MonHoc.Rows[dong].Cells[0].Value.ToString();
            txt_TenMonHoc.Text = dgv_MonHoc.Rows[dong].Cells[1].Value.ToString();
            txt_SoTiet.Text = dgv_MonHoc.Rows[dong].Cells[2].Value.ToString();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_MaMoHoc.Clear();
            txt_TenMonHoc.Clear();
            txt_SoTiet.Clear();
            txt_TenMonHoc.Focus();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenMonHoc.TextLength == 0)
                MessageBox.Show("Tên Môn Học không được để trống!");
            else if (txt_SoTiet.TextLength == 0)
                MessageBox.Show("Số Tiết không được để trống!");
            else
            {
                try
                {
                    string tenmonhoc = txt_TenMonHoc.Text;
                    int sotiet = Int32.Parse(txt_SoTiet.Text);
                    monhoch.InsertMonHoc(tenmonhoc,sotiet);
                    MessageBox.Show("Thêm thành công!");
                    QuanLyMonHoc_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_MaMoHoc.TextLength == 0)
                MessageBox.Show("Mã Môn Học không được để trống!");
            else if (txt_TenMonHoc.TextLength == 0)
                MessageBox.Show("Tên Môn Học không được để trống!");
            else if (txt_SoTiet.TextLength == 0)
                MessageBox.Show("Số Tiết không được để trống!");
            else
            {
                try
                {
                    string mamonhoc = txt_MaMoHoc.Text;
                    string tenmonhoc = txt_TenMonHoc.Text;
                    int sotiet = Int32.Parse(txt_SoTiet.Text);


                    monhoch.UpdateMonHoc(mamonhoc,tenmonhoc,sotiet);
                    MessageBox.Show("Sửa Thành Công ! ");
                    QuanLyMonHoc_Load(sender, e);
                }
                catch { MessageBox.Show("Có lỗi!"); 
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaMoHoc.TextLength == 0)
                MessageBox.Show("Bạn cần chọn môn học để xóa");
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn chắc chắn muốn Xoá ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    string mamonhoc = txt_MaMoHoc.Text;
                    monhoch.DeleteMonHoc(mamonhoc);
                    MessageBox.Show("Đã Xóa Thành Công");
                    QuanLyMonHoc_Load(sender, e);
                }

            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.TextLength == 0)
            {
                MessageBox.Show("Bạn cần nhập từ khóa để tìm kiếm.");

            }
            else
            {

                dgv_MonHoc.DataSource = monhoch.LookMonHoc(txt_TimKiem.Text);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

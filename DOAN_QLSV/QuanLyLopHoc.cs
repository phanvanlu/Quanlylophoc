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
    public partial class QuanLyLopHoc : Form
    {
        public QuanLyLopHoc()
        {
            InitializeComponent();
        }
        BUS_UC1_QuanLyLopHoc lophoch = new BUS_UC1_QuanLyLopHoc();
        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            dgv_LopHoc.DataSource = lophoch.ShowLopHoc();


        }

        private void dgv_LopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_MaLop.Text = dgv_LopHoc.Rows[dong].Cells[0].Value.ToString();
            txt_TenLop.Text = dgv_LopHoc.Rows[dong].Cells[1].Value.ToString();
            txt_NienKhoa.Text = dgv_LopHoc.Rows[dong].Cells[2].Value.ToString();
            txt_SiSo.Text = dgv_LopHoc.Rows[dong].Cells[3].Value.ToString();
            txtGVCN.Text = dgv_LopHoc.Rows[dong].Cells[4].Value.ToString();
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txt_MaLop.Clear();
            txt_TenLop.Clear();
            txt_NienKhoa.Clear();
            txt_SiSo.Clear();
            txtGVCN.Clear();
            txt_TenLop.Focus();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txt_TenLop.TextLength == 0)
                MessageBox.Show("Tên Lớp không được để trống!");
            else if (txt_NienKhoa.TextLength == 0)
                MessageBox.Show("Niên khóa không được để trống!");
            else if (txt_SiSo.TextLength == 0)
                MessageBox.Show("Sĩ số không được để trống!");

            else
            {
                try
                {
                    string tenlop = txt_TenLop.Text;
                    string nienkhoa = txt_NienKhoa.Text;
                    int siso = Int32.Parse(txt_SiSo.Text);
                    string giaovienchunhiem = txtGVCN.Text;

                    lophoch.InsertLopHoc(tenlop, nienkhoa, siso,giaovienchunhiem);

                    MessageBox.Show("Thêm thành công!");
                    QuanLyLopHoc_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi!", ex.Message);
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txt_MaLop.TextLength == 0)
                MessageBox.Show("Mã Lớp không được để trống!");
            else if (txt_TenLop.TextLength == 0)
                MessageBox.Show("Tên Lớp không được để trống!");
            else if (txt_NienKhoa.TextLength == 0)
                MessageBox.Show("Niên khóa không được để trống!");
            else if (txt_SiSo.TextLength == 0)
                MessageBox.Show("Sĩ số không được để trống!");
            else if (txtGVCN.TextLength == 0)
                MessageBox.Show("Giáo viên chủ nhiệm không được để trống!");
            else
            {
                try
                {
                    string malop = txt_MaLop.Text;
                    string tenlop = txt_TenLop.Text;
                    string nienkhoa = txt_NienKhoa.Text;
                    int siso = Int32.Parse(txt_SiSo.Text);
                    string gvcn = txtGVCN.Text;


                    lophoch.UpdateLopHoc(malop,tenlop,nienkhoa,siso,gvcn);
                    MessageBox.Show("Sửa Thành Công ! ");
                    QuanLyLopHoc_Load(sender, e);
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txt_MaLop.TextLength == 0)
                MessageBox.Show("Bạn cần có mã lớp để xóa");
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn chắc chắn muốn Xoá ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    string malop = txt_MaLop.Text;
                    lophoch.DeleteLopHoc(malop);
                    MessageBox.Show("Đã Xóa Thành Công");
                    QuanLyLopHoc_Load(sender, e);
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

                dgv_LopHoc.DataSource = lophoch.LookLopHoc(txt_TimKiem.Text);
            }
        }





    }
}

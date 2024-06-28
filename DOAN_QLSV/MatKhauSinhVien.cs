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
    public partial class MatKhauSinhVien : Form
    {
        public MatKhauSinhVien()
        {
            InitializeComponent();
        }
        BUS_UC1_MatKhauSV matkhauh = new BUS_UC1_MatKhauSV();
        private void MatKhauSinhVien_Load(object sender, EventArgs e)
        {
            dgv_MatKhau.DataSource = matkhauh.ShowMatKhau();
            cbxMaSV.DataSource = matkhauh.ShowMSSV();
            cbxMaSV.DisplayMember = "MaSV";
            cbxMaSV.ValueMember = "MaSV";
            
        }
        private void cbxMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxHoVaTen.DataSource = matkhauh.ShowHoTenSV(cbxMaSV.SelectedValue.ToString());
            cbxHoVaTen.DisplayMember = "HoTen";
            cbxHoVaTen.ValueMember = "HoTen";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (cbxMaSV.Text =="")
                MessageBox.Show("Mã sinh viên không được để trống!");
            else if (cbxHoVaTen.Text == "")
                MessageBox.Show("Họ tên không được để trống!");
            else if (txtTaiKhoan.Text == "")
                MessageBox.Show("Tài khoản không được để trống!");
            else
            {
                try
                {
                    string masv = cbxMaSV.Text;
                    string taikhoan = txtTaiKhoan.Text;
                    string matkhau = txtMatKhau.Text;
                    matkhauh.InsertMatKhau(matkhau,taikhoan,masv);
                    MessageBox.Show("Thêm thành công!");
                    MatKhauSinhVien_Load(sender, e);
                    txtTaiKhoan.Clear();
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            /*if (cbxMaSV.Text == "")
                MessageBox.Show("Mã sinh viên không được để trống!");
            else if (cbxHoVaTen.Text == "")
                MessageBox.Show("Họ tên không được để trống!");
            else if (txtTaiKhoan.Text == "")
                MessageBox.Show("Tài khoản không được để trống!");
            else
            {
                try
                {
                    string masv = cbxMaSV.Text;
                    string taikhoan = txtTaiKhoan.Text;
                    string matkhau = txtMatKhau.Text;
                    matkhauh.UpdateMatKhau(masv, taikhoan, matkhau);
                    MessageBox.Show("Sửa Thành Công ! ");
                    MatKhauSinhVien_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }*/
        }

        private void dgv_MatKhau_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            cbxMaSV.Text = dgv_MatKhau.Rows[dong].Cells[2].Value.ToString();
            txtTaiKhoan.Text = dgv_MatKhau.Rows[dong].Cells[1].Value.ToString();
            txtMatKhau.Text =  dgv_MatKhau.Rows[dong].Cells[0].Value.ToString();
          
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

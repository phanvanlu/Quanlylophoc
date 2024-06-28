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
    public partial class QuanLyGiaoVien : Form
    {
        public QuanLyGiaoVien()
        {
            InitializeComponent();
        }
        BUS_UC1_QuanLyGiaoVien cbgvh = new BUS_UC1_QuanLyGiaoVien();
        private void QuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            cmbDiaChi.Items.Add("An Giang");
            cmbDiaChi.Items.Add("Bà Rịa – Vũng Tàu");
            cmbDiaChi.Items.Add("Bắc Giang");
            cmbDiaChi.Items.Add("Bắc Kạn");
            cmbDiaChi.Items.Add("Bạc Liêu");
            cmbDiaChi.Items.Add("Bến Tre");
            cmbDiaChi.Items.Add("Bình Định");
            cmbDiaChi.Items.Add("Bình Dương");
            cmbDiaChi.Items.Add("Bình Phước");
            cmbDiaChi.Items.Add("Bình Thuận");
            cmbDiaChi.Items.Add("Cà Mau");
            cmbDiaChi.Items.Add("Cần Thơ");
            cmbDiaChi.Items.Add("Đà Nẵng");
            cmbDiaChi.Items.Add("Đồng Nai");
            cmbDiaChi.Items.Add("Đồng Tháp");
            cmbDiaChi.Items.Add("Gia Lai");
            cmbDiaChi.Items.Add("Hà Giang");
            cmbDiaChi.Items.Add("Hà Nam");
            cmbDiaChi.Items.Add("Hà Nội");
            cmbDiaChi.Items.Add("Hà Tĩnh");
            cmbDiaChi.Items.Add("Hải Dương");
            cmbDiaChi.Items.Add("Sóc Trăng");
            cmbDiaChi.Items.Add("Hải Phòng");
            cmbDiaChi.Items.Add("Hậu Giang");
            cmbDiaChi.Items.Add("Hòa Bình");
            cmbDiaChi.Items.Add("Kiên Giang");
            cmbDiaChi.Items.Add("Khánh Hòa");
            cmbDiaChi.Items.Add("Vĩnh Long");
            cmbDiaChi.Items.Add("Trà Vinh");
            cmbDiaChi.Items.Add("Tiền Giang");
            cmbDiaChi.Items.Add("TP Hồ Chí Minh");
            cmbDiaChi.Items.Add("Long An");
            cmbDiaChi.Items.Add("Tây Ninh");
            cmbDiaChi.Items.Add("Vĩnh Phúc");
            cmbDiaChi.SelectedIndex = 0;
            dgv_CBGV.DataSource = cbgvh.ShowCanBoGiaoVien();
            cbo_TrinhDo.DataSource = cbgvh.ShowTrinhDo();
            cbo_TrinhDo.DisplayMember = "TenTD";
            cbo_TrinhDo.ValueMember = "MaTD";

            cbo_LoaiTK.DataSource = cbgvh.ShowLoaiTaiKhoan();
            cbo_LoaiTK.DisplayMember = "LoaiTaiKhoan";
            cbo_LoaiTK.ValueMember = "LoaiTaiKhoan";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txt_TenCBGV.TextLength == 0)
                MessageBox.Show("Tên CBGV không được để trống!");
            else if (txt_SoDienThoai.TextLength == 0)
                MessageBox.Show("SDT không được để trống!");
            else if (txt_TaiKhoan.TextLength == 0)
                MessageBox.Show("Tài khoản không được để trống!");
            else if (txt_MatKhau.TextLength == 0)
                MessageBox.Show("Mật khẩu không được để trống!");

            else
            {
                try
                {
                    string tengiaovien = txt_TenCBGV.Text;
                    string diachi = cmbDiaChi.Text;
                    string sodienthoai = txt_SoDienThoai.Text;
                    string taikhoan = txt_TaiKhoan.Text;
                    string matkhau = txt_MatKhau.Text;
                    string hinhanh = txt_hinhanh.Text;
                    string loaitaikhoan = cbo_LoaiTK.SelectedValue.ToString();
                    string matrinhdo = cbo_TrinhDo.SelectedValue.ToString();//cho nhay cam
                    //MessageBox.Show("cec");

                    cbgvh.InsertCanBoGiaoVien(tengiaovien, diachi, sodienthoai, taikhoan, matkhau, hinhanh, loaitaikhoan, matrinhdo);

                    MessageBox.Show("Thêm thành công!");
                    QuanLyGiaoVien_Load(sender, e);
                    
                }
                catch
                {
                    MessageBox.Show("Có lỗiiiiiiiiiiiiiiiiiiiiii!");
                }
            }
        }

        private void btn_Anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlr = new OpenFileDialog();
            if (dlr.ShowDialog() == DialogResult.OK)
                txt_hinhanh.Text = dlr.FileName;
        }

        private void txt_hinhanh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(txt_hinhanh.Text);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm ảnh thất bại", ex.Message);
            }
        }

        private void dgv_CBGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_MaCBGV.Text = dgv_CBGV.Rows[dong].Cells[0].Value.ToString();
            txt_TenCBGV.Text = dgv_CBGV.Rows[dong].Cells[1].Value.ToString();
            cmbDiaChi.Text = dgv_CBGV.Rows[dong].Cells[2].Value.ToString();
            txt_SoDienThoai.Text = dgv_CBGV.Rows[dong].Cells[3].Value.ToString();
            txt_TaiKhoan.Text = dgv_CBGV.Rows[dong].Cells[4].Value.ToString();
            txt_MatKhau.Text = dgv_CBGV.Rows[dong].Cells[5].Value.ToString();
            txt_hinhanh.Text = dgv_CBGV.Rows[dong].Cells[6].Value.ToString();
            cbo_LoaiTK.SelectedValue = dgv_CBGV.Rows[dong].Cells[7].Value.ToString();
            cbo_TrinhDo.SelectedValue = dgv_CBGV.Rows[dong].Cells[8].Value.ToString();

            cmbChuyenNganh.DataSource = cbgvh.ShowChuyenNganh(cbo_TrinhDo.SelectedValue.ToString());
            cmbChuyenNganh.DisplayMember = "ChuyenNganh";
            cmbChuyenNganh.ValueMember = "ChuyenNganh";
        }
        private void cbo_TrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbChuyenNganh.DataSource = cbgvh.ShowChuyenNganh(cbo_TrinhDo.SelectedValue.ToString());
            cmbChuyenNganh.ValueMember = "ChuyenNganh";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txt_TenCBGV.TextLength == 0)
                MessageBox.Show("Tên CBGV không được để trống!");
            else if (txt_SoDienThoai.TextLength == 0)
                MessageBox.Show("SDT không được để trống!");
            else if (txt_TaiKhoan.TextLength == 0)
                MessageBox.Show("Tài khoản không được để trống!");
            else if (txt_MatKhau.TextLength == 0)
                MessageBox.Show("Mật khẩu không được để trống!");
            else
            {
                try
                {
                    string magiaovien = txt_MaCBGV.Text;
                    string tengiaovien = txt_TenCBGV.Text;
                    string diachi = cmbDiaChi.Text;
                    string sodienthoai = txt_SoDienThoai.Text;
                    string taikhoan = txt_TaiKhoan.Text;
                    string matkhau = txt_MatKhau.Text;
                    string hinhanh = txt_hinhanh.Text;
                    string loaitaikhoan = cbo_LoaiTK.SelectedValue.ToString();
                    string trinhdo = cbo_TrinhDo.SelectedValue.ToString();//cho nhay cam


                    cbgvh.UpdateCanBoGiaoVien(magiaovien, tengiaovien, diachi, sodienthoai, taikhoan, matkhau, hinhanh, loaitaikhoan, trinhdo);
                    MessageBox.Show("Sửa Thành Công ! ");
                    QuanLyGiaoVien_Load(sender, e);
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi!",ex.Message);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txt_MaCBGV.TextLength == 0)
                MessageBox.Show("Bạn cần nhập mã giáo viên để xóa");
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn chắc chắn muốn Xoá ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    try
                    {
                        string magiaovien = txt_MaCBGV.Text;
                        cbgvh.DeleteCanBoGiaoVien(magiaovien);
                        MessageBox.Show("Đã Xóa Thành Công");
                        QuanLyGiaoVien_Load(sender, e);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại!" + ex.Message);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_hinhanh.Text = "D:\\DOAN_QLSV\\DOAN_QLSV\\Resource\\user_456212.png";
            txt_MaCBGV.Clear();
            txt_TenCBGV.Clear();
            txt_SoDienThoai.Clear();
            txt_TaiKhoan.Clear();
            txt_MatKhau.Clear();
            txt_TenCBGV.Focus();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.TextLength == 0)
            {
                MessageBox.Show("Bạn cần nhập từ khóa để tìm kiếm.");

            }
            else
            {

                dgv_CBGV.DataSource = cbgvh.LookCanBoGiaoVien(txt_TimKiem.Text);
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

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
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }
        BUS_UC1_QuanLySinhVien hocsinhh = new BUS_UC1_QuanLySinhVien();
        private void QuanLySinhVien_Load(object sender, EventArgs e)
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

            dgv_HocSinh.DataSource = hocsinhh.ShowHocSinh();


            cbo_TenLop.DataSource = hocsinhh.ShowTenLop();
            cbo_TenLop.DisplayMember = "TenLop";
            cbo_TenLop.ValueMember = "MaLop";
        }

        private void dgv_HocSinh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_MaHocSinh.Text = dgv_HocSinh.Rows[dong].Cells[0].Value.ToString();
            txt_TenHocSinh.Text = dgv_HocSinh.Rows[dong].Cells[1].Value.ToString();
            dtngaysinh.Text = dgv_HocSinh.Rows[dong].Cells[2].Value.ToString();

            string gt = this.dgv_HocSinh.Rows[dong].Cells[3].Value.ToString();
            if (gt.Trim() == "Nam")
            {
                rb_Nam.Checked = true;
            }
            else
            {
                rb_Nu.Checked = true;
            }

            cmbDiaChi.Text = dgv_HocSinh.Rows[dong].Cells[4].Value.ToString();
            txt_DiemVaoTruong.Text = dgv_HocSinh.Rows[dong].Cells[5].Value.ToString();
            txt_BoMe.Text = dgv_HocSinh.Rows[dong].Cells[6].Value.ToString();
            txt_SoDienThoai.Text = dgv_HocSinh.Rows[dong].Cells[7].Value.ToString();
            txt_hinhanh.Text = dgv_HocSinh.Rows[dong].Cells[8].Value.ToString();
            cbo_TenLop.SelectedValue = dgv_HocSinh.Rows[dong].Cells[9].Value.ToString();
        }

        private void txt_hinhanh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(txt_hinhanh.Text);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm ảnh thất bại", ex.Message);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txt_TenHocSinh.TextLength == 0)
                MessageBox.Show("Tên Học Sinh không được để trống!");
            else if (rb_Nam.Checked == false && rb_Nu.Checked == false)
                MessageBox.Show("Bạn phải chọn giới tính!");
            else if (txt_DiemVaoTruong.TextLength == 0)
                MessageBox.Show("Điểm vào trường không được để trống!");
            else if (txt_BoMe.TextLength == 0)
                MessageBox.Show("Họ Tên Bố Mẹ không được để trống!");
            else if (txt_SoDienThoai.TextLength == 0)
                MessageBox.Show("SDT không được để trống!");
            else if (cbo_TenLop.Text == "")
                MessageBox.Show("Tên Lớp không được để trống!");
            else
            {
                try
                {
                    string ten = txt_TenHocSinh.Text;
                    string ngaysinh = dtngaysinh.Value.ToString("yyyy-MM-dd");
                    string gioitinh = "";
                    if (rb_Nam.Checked)
                    {
                        gioitinh = "Nam";
                    }
                    else
                    {
                        gioitinh = "Nữ";
                    }

                    string diachi = cmbDiaChi.Text;
                    float diemvaotruong = float.Parse(txt_DiemVaoTruong.Text);
                    string hotenbome = txt_BoMe.Text;
                    string sodienthoai = txt_SoDienThoai.Text;
                    string hinhanh = txt_hinhanh.Text;
                    string malop = cbo_TenLop.SelectedValue.ToString();

                    //MessageBox.Show("cec");

                    hocsinhh.InsertHocSinh(ten,ngaysinh,gioitinh,diachi,diemvaotruong,hotenbome,sodienthoai,hinhanh,malop);

                    MessageBox.Show("Thêm thành công!");
                    QuanLySinhVien_Load(sender, e);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗiiiiiiiiiiiiiiiiiiiiii!", ex.Message);
                }
            }
        }

        private void btn_Anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlr = new OpenFileDialog();
            if (dlr.ShowDialog() == DialogResult.OK)
                txt_hinhanh.Text = dlr.FileName;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txt_TenHocSinh.TextLength == 0)
                MessageBox.Show("Tên Học Sinh không được để trống!");
            else if (rb_Nam.Checked == false && rb_Nu.Checked == false)
                MessageBox.Show("Bạn phải chọn giới tính!");
            else if (cmbDiaChi.Text == "")
                MessageBox.Show("Địa chỉ không được để trống!");
            else if (txt_DiemVaoTruong.TextLength == 0)
                MessageBox.Show("Điểm vào trường không được để trống!");
            else if (txt_BoMe.TextLength == 0)
                MessageBox.Show("Họ Tên Bố Mẹ không được để trống!");
            else if (txt_SoDienThoai.TextLength == 0)
                MessageBox.Show("SDT không được để trống!");
            else if (cbo_TenLop.Text == "")
                MessageBox.Show("Mã Lớp không được để trống!");
            else
            {
                try
                {
                    string masv = txt_MaHocSinh.Text;
                    string ten = txt_TenHocSinh.Text;
                    string ngaysinh = dtngaysinh.Value.ToString("yyyy-MM-dd");
                    string gioitinh = "";
                    if (rb_Nam.Checked)
                    {
                        gioitinh = "Nam";
                    }
                    else
                    {
                        gioitinh = "Nữ";
                    }

                    string diachi = cmbDiaChi.Text;
                    float diemvaotruong = float.Parse(txt_DiemVaoTruong.Text);
                    string hotenbome = txt_BoMe.Text;
                    string sodienthoai = txt_SoDienThoai.Text;
                    string hinhanh = txt_hinhanh.Text;
                    string malop = cbo_TenLop.SelectedValue.ToString();


                    hocsinhh.UpdateHocSinh(masv,ten,ngaysinh,gioitinh,diachi,diemvaotruong,hotenbome,sodienthoai,hinhanh,malop);
                    MessageBox.Show("Sửa Thành Công ! ");
                    QuanLySinhVien_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗiiiiiiiiiiiiiiiiiiiiii!", ex.Message);
                }
            }
        }

        private void btnNhapLai_Click_1(object sender, EventArgs e)
        {
            txt_hinhanh.Text = "D:\\DOAN_QLSV\\DOAN_QLSV\\Resource\\user_456212.png";
            txt_MaHocSinh.Clear();
            txt_TenHocSinh.Clear();
            txt_DiemVaoTruong.Clear();
            txt_BoMe.Clear();
            txt_SoDienThoai.Clear();
            txt_TenHocSinh.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txt_MaHocSinh.TextLength == 0)
                MessageBox.Show("Bạn cần nhập mã học sinh để xóa");
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn chắc chắn muốn Xoá ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    string masv = txt_MaHocSinh.Text;
                    hocsinhh.DeleteHocSinh(masv);
                    MessageBox.Show("Đã Xóa Thành Công");
                    QuanLySinhVien_Load(sender, e);
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.TextLength == 0)
            {
                MessageBox.Show("Bạn cần nhập từ khóa để tìm kiếm.");

            }
            else
            {

                dgv_HocSinh.DataSource = hocsinhh.LookHocSinh(txt_TimKiem.Text);
            }
        }





    }
}

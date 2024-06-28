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
    public partial class QuanLyTrinhDo : Form
    {
        public QuanLyTrinhDo()
        {
            InitializeComponent();
        }
        BUS_UC1_QuanLyTrinhDo trinhdoh = new BUS_UC1_QuanLyTrinhDo();
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTenTrinhDo.Items.Add("Giảng Viên");
            cmbTenTrinhDo.Items.Add("Thạc Sĩ");
            cmbTenTrinhDo.Items.Add("Tiến Sĩ");
            cmbTenTrinhDo.Items.Add("Phó Giáo Sư");
            cmbTenTrinhDo.Items.Add("Giáo Sư");

            cmbChuyenNganh.Items.Add("Công nghệ thông tin");
            cmbChuyenNganh.Items.Add("Ngôn ngữ Anh");
            cmbChuyenNganh.Items.Add("Quản Trị");
            cmbChuyenNganh.Items.Add("Du Lịch");
            dgv_TrinhDo.DataSource = trinhdoh.ShowTrinhDO();

        }
        private void dgv_TrinhDo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_MaTrinhDo.Text = dgv_TrinhDo.Rows[dong].Cells[0].Value.ToString();
            cmbTenTrinhDo.Text = dgv_TrinhDo.Rows[dong].Cells[1].Value.ToString();
            cmbChuyenNganh.Text = dgv_TrinhDo.Rows[dong].Cells[2].Value.ToString();
           
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
                try
                {
                    string tentrinhdo = cmbTenTrinhDo.Text;
                    string chuyennganh = cmbChuyenNganh.Text;
                    trinhdoh.InsertTrinhDo(tentrinhdo,chuyennganh);
                    MessageBox.Show("Thêm thành công!");
                    Form1_Load(sender, e);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm thất bại!" + ex.Message);
                }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

                try
                {
                    string matrinhdo = txt_MaTrinhDo.Text;
                    string tentrinhdo = cmbTenTrinhDo.Text;
                    string chuyennganh = cmbChuyenNganh.Text;
                    trinhdoh.UpdateTrinhDO(matrinhdo,tentrinhdo,chuyennganh);
                    MessageBox.Show("Sửa Thành Công ! ");
                    Form1_Load(sender, e);
                    txt_MaTrinhDo.Clear();
                    txt_MaTrinhDo.Focus();
                }
                catch(Exception ex) { 
                    MessageBox.Show("Sửa thất bại!" + ex.Message); 
                }
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaTrinhDo.TextLength == 0)
                MessageBox.Show("Bạn cần nhập mã Trình Độ để xóa");
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn chắc chắn muốn Xoá ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    try
                    {
                        string matrinhdo = txt_MaTrinhDo.Text;
                        trinhdoh.DeleteTrinhDo(matrinhdo);
                        MessageBox.Show("Xóa Thành Công ! ");
                        Form1_Load(sender, e);
                        txt_MaTrinhDo.Clear();
                        txt_MaTrinhDo.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại!" + ex.Message);
                    }
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

                dgv_TrinhDo.DataSource = trinhdoh.LookTrinhDo(txt_TimKiem.Text);
            }
        }

        private void btn_NhapLai_Click_1(object sender, EventArgs e)
        {
            txt_MaTrinhDo.Clear();
            txt_TimKiem.Clear();
            txt_TimKiem.Focus();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_QLSV
{
    class BUS_UC4_DanhSachSinhVien1Lop
    {
        Data da = new Data();

        public DataTable ShowDanhSachHocSinh(string ml)//lam cuoi
        {
            string sql = "select MaSV,HoTen,NgaySinh,GioiTinh,DiaChi,DiemVaoTruong,HoTenBoMe,SoDienThoai from tblSinhVien where MaLop = '" + ml + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTenLopHoc()
        {
            string sql = "select * from tblLop ";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowNienKhoa(string ml)
        {
            string sql = "select NienKhoa from tblLop where MaLop = '" + ml + "'";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowSiSo(string ml)
        {
            string sql = "select SiSo from tblLop where MaLop = '" + ml + "'";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowGiaoVienChuNhiem(string ml)
        {
            string sql = "select GiaoVienChuNhiem from tblLop where MaLop = '" + ml + "'";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}

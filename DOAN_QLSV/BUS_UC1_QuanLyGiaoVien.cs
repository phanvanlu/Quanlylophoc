using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_QLSV
{
    public class BUS_UC1_QuanLyGiaoVien
    {
        Data da = new Data();

        public DataTable ShowCanBoGiaoVien()
        {
            string sql = "select * from tblGiaoVien";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowChuyenNganh(string mtd)
        {
            string sql = "select ChuyenNganh from tblTrinhDo where MaTD = N'" + mtd + "'";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTrinhDo()
        {
            string sql = "select * from tblTrinhDo";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowLoaiTaiKhoan()
        {
            string sql = "select distinct LoaiTaiKhoan from tblGiaoVien order by LoaiTaiKhoan";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertCanBoGiaoVien(string tcb, string dc, string sdt, string tk, string mk, string ha, string ltk, string mtd)
        {
            string sql = "insert tblGiaoVien values('GV' + cast(next value for GiaoVienSeq as nvarchar(50)),N'" + tcb + "',N'" + dc + "',N'" + sdt + "',N'" + tk + "','" + mk + "','" + ha + "',N'" + ltk + "',N'" + mtd + "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdateCanBoGiaoVien(string mcb, string tcb, string dc, string sdt, string tk, string mk, string ha, string ltk, string mtd)
        {
            string sql = "update tblGiaoVien set HoTen=N'" + tcb + "', DiaChi=N'" + dc + "', SoDienThoai=N'" + sdt + "', TaiKhoan=N'" + tk + "', MatKhau='" + mk + "', HinhAnh='" + ha + "', LoaiTaiKhoan=N'" + ltk + "', MaTD=N'" + mtd + "' where MaGiaoVien=N'" + mcb + "'";
            da.ExcuteNonQuery(sql);//da xong
        }
        public void DeleteCanBoGiaoVien(string mcb)
        {
            string sql = "delete tblGiaoVien where MaGiaoVien = N'" + mcb + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable LookCanBoGiaoVien(string dk)
        {
            string sql = "select * from tblGiaoVien where MaGiaoVien like N'%" + dk + "%' OR HoTen like N'%" + dk + "%' OR DiaChi like N'%" + dk + "%' OR TaiKhoan like N'%" + dk + "%' OR LoaiTaiKhoan like '%" + dk + "%' OR MaTD like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}

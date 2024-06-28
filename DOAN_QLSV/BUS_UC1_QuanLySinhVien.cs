using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_QLSV
{
    class BUS_UC1_QuanLySinhVien
    {
        Data da = new Data();

        public DataTable ShowHocSinh()
        {
            string sql = "select * from tblSinhVien";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTenLop()
        {
            string sql = "select * from tblLop";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertHocSinh(string ths, string ns, string gt, string dc, float d, string htbm, string sdt, string ha, string ml)
        {

            string sql = "insert into tblSinhVien values('SV' + cast(next value for SinhVienSeq as nvarchar(50)),N'" + ths + "','" + ns + "',N'" + gt + "',N'" + dc + "','" + d + "',N'" + htbm + "',N'" + sdt + "',N'" + ha + "',N'" + ml + "')";
            //MessageBox.Show(sql);
            da.ExcuteNonQuery(sql);


        }
        public void UpdateHocSinh(string mhs, string ths, string ns, string gt, string dc, float d, string htbm, string sdt, string ha, string ml)
        {
            string sql = "update tblSinhVien set HoTen=N'" + ths + "', NgaySinh='" + ns + "', GioiTinh=N'" + gt + "', DiaChi=N'" + dc + "', DiemVaoTruong='" + d + "', HoTenBoMe=N'" + htbm + "', SoDienThoai=N'" + sdt + "', HinhAnh=N'" + ha + "', MaLop=N'" + ml + "' where MaSV=N'" + mhs + "'";
            da.ExcuteNonQuery(sql);//da xong
        }
        public void DeleteHocSinh(string mhs)
        {
            string sql = "delete tblSinhVien where MaSV = N'" + mhs + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable LookHocSinh(string dk)
        {
            string sql = "select * from tblSinhVien where MaSV like N'%" + dk + "%' OR HoTen like N'%" + dk + "%' OR DiaChi like N'%" + dk + "%' OR HoTenBoMe like N'%" + dk + "%' OR DiemVaoTruong like N'%" + dk + "%' OR SoDienThoai like N'%" + dk + "%' OR MaLop like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}

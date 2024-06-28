using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_QLSV
{
    class BUS_UC2_ThemSuaXemInDiem
    {
        Data da = new Data();

        public DataTable ShowDiem(string ml, string mm)
        {
            string sql = "select tblSinhVien.MaSV,tblSinhVien.HoTen,DiemLan1,DiemLan2,(DiemLan1+DiemLan2)/2 as 'DiemTB', case when(DiemLan1 + DiemLan2) / 2 >= 8.5 then N'Giỏi' when(DiemLan1 + DiemLan2) / 2 >= 7 then 'Khá' when(DiemLan1 + DiemLan2) / 2 >= 5.5 then 'Trung bình' when(DiemLan1 + DiemLan2) / 2 >= 4 then 'Yếu' when(DiemLan1 + DiemLan2) / 2 >= 0 then 'Fail' end as 'XepLoai' from tblDiem inner join tblSinhVien on tblDiem.MaSV = tblSinhVien.MaSV where tblSinhVien.MaLop = '" + ml + "' and tblDiem.MaMH = '" + mm + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTenLop()
        {
            string sql = "select * from tblLop";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTenMon(string malop)
        {
            string sql = "select * from tblMonHoc,tblLichHocPhan  where tblMonHoc.MaMH = tblLichHocPhan.MaMH and MaLop = N'" + malop + "'";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable ShowMaSV(string mamon)
        {
            string sql = "select * from tblSinhVien,tblDiem where tblSinhVien.MaSV = tblDiem.MaSV and tblDiem.MaMH =N'" + mamon + "'";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTenSV(string masv)
        {
            string sql = "select HoTen from tblSinhVien where MaSV = N'" + masv + "'";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertDiem(string mhs, string hoten, string mamonhoc, string tenmonhoc, float dk1, float dk2)
        {
            string sql = "insert into tblDiem values(N'" + mhs + "',N'" + hoten + "',N'" + mamonhoc + "',N'" + tenmonhoc + "','" + dk1 + "','" + dk2 + "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdateDiem(string mhs, string hoten, string mamonhoc, string tenmonhoc, float dk1, float dk2)
        {
            string sql = "update tblDiem set MaSV = N'" + mhs + "',HoTen = N'" + hoten + "',TenMH = N'" + tenmonhoc + "',DiemLan1 = '" + dk1 + "', DiemLan2 = '" + dk2 + "' where MaSV = N'" + mhs + "' and MaMH = N'" + mamonhoc + "'";
            da.ExcuteNonQuery(sql);//da xong
        }
        /*
        
        public DataTable LookCanBoGiaoVien(string dk)
        {
            string sql = "select * from CanBoGiaoVien9 where MaCanBoGV like N'%" + dk + "%' OR HoTen like N'%" + dk + "%' OR DiaChi like N'%" + dk + "%' OR TaiKhoan like N'%" + dk + "%' OR LoaiTaiKhoan like '%" + dk + "%' OR MaTD like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }*/
  
    }
}

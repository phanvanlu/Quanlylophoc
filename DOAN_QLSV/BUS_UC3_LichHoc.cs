using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_QLSV
{
    class BUS_UC3_LichHoc
    {
        Data da = new Data();
        public DataTable ShowPCGD()
        {
            string sql = "select tblLop.TenLop,tblMonHoc.TenMH,tblGiaoVien.HoTen,PhongHoc,NgayHoc,GioBD,GioKT from tblLichHocPhan inner join tblLop on tblLichHocPhan.MaLop = tblLop.MaLop inner join tblMonHoc on tblLichHocPhan.MaMH = tblMonHoc.MaMH inner join tblGiaoVien on tblLichHocPhan.MaGiaoVien = tblGiaoVien.MaGiaoVien";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTenLopHoc()
        {
            string sql = "select * from tblLop";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTenMonHoc()
        {
            string sql = "select * from tblMonHoc";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTenCBGV()
        {
            string sql = "select * from tblGiaoVien";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }


        public void InsertPhanCongGiangDay(string ml, string tl, string mmh, string tmh, string mgv, string hoten, int phonghoc, string ngay, string gbd, string gkt)
        {
            string sql = "insert tblLichHocPhan values(N'" + ml + "',N'" + tl + "',N'" + mmh + "',N'" + tmh + "',N'" + mgv + "',N'" + hoten + "'," + phonghoc + ",'" + ngay + "',N'" + gbd + "',N'" + gkt + "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdatePhanCongGiangDay(string ml, string tl, string mmh, string tmh, string mgv, string hoten, int phonghoc, string ngay, string gbd, string gkt)
        {
            string sql = "update tblLichHocPhan set MaLop = N'" + ml + "' ,TenLop = N'" + tl + "' , MaMH = N'" + mmh + "' ,TenMH = N'" + tmh + "' , MaGiaoVien = N'" + mgv + "' , HoTen = N'" + hoten + "', PhongHoc = " + phonghoc + ", NgayHoc = '" + ngay + "' , GioBD = N'" + gbd + "' , GioKT = N'" + gkt + "' where MaLop = N'" + ml + "' and MaMH = N'" + mmh + "' and MaGiaoVien = N'" + mgv + "' ";
            da.ExcuteNonQuery(sql);//da xong
        }
        public void DeletePhanCongGiangDay(string ml,string mmh,string mgv)
        {
            string sql = "delete tblLichHocPhan where MaLop = N'" + ml + "' and MaMH = N'" + mmh + "' and MaGiaoVien = N'" + mgv + "'";
            da.ExcuteNonQuery(sql);
        }


        public DataTable LookXemPhanCongGiangDayThemMaLop(string malop)
        {
            string sql = "(select tblLop.TenLop, tblMonHoc.TenMH, tblGiaoVien.HoTen,PhongHoc, NgayHoc,GioBD,GioKT from tblLichHocPhan inner join tblLop on tblLichHocPhan.MaLop = TblLop.MaLop inner join tblMonHoc on tblLichHocPhan.MaMH = tblMonHoc.MaMH inner join tblGiaoVien on tblLichHocPhan.MaGiaoVien = tblGiaoVien.MaGiaoVien where tblLop.MaLop = N'" +malop+"')";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable LookXemPhanCongGiangDayThemMonHoc(string mamonhoc)
        {
            string sql = "(select tblLop.TenLop, tblMonHoc.TenMH, tblGiaoVien.HoTen,PhongHoc, NgayHoc,GioBD,GioKT from tblLichHocPhan inner join tblLop on tblLichHocPhan.MaLop = TblLop.MaLop inner join tblMonHoc on tblLichHocPhan.MaMH = tblMonHoc.MaMH inner join tblGiaoVien on tblLichHocPhan.MaGiaoVien = tblGiaoVien.MaGiaoVien where tblMonHoc.MaMH = N'" + mamonhoc + "')";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable LookXemPhanCongGiangDayThemGiaoVien(string magiaovien)
        {
            string sql = "(select tblLop.TenLop, tblMonHoc.TenMH, tblGiaoVien.HoTen,PhongHoc, NgayHoc,GioBD,GioKT from tblLichHocPhan inner join tblLop on tblLichHocPhan.MaLop = TblLop.MaLop inner join tblMonHoc on tblLichHocPhan.MaMH = tblMonHoc.MaMH inner join tblGiaoVien on tblLichHocPhan.MaGiaoVien = tblGiaoVien.MaGiaoVien where tblGiaoVien.MaGiaoVien = N'" + magiaovien + "')";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}

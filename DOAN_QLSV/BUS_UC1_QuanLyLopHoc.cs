using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DOAN_QLSV
{
    class BUS_UC1_QuanLyLopHoc
    {
        Data da = new Data();

        public DataTable ShowLopHoc()
        {
            string sql = "select * from tblLop";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowGiaoVienChuNhiem()
        {
            string sql = "select GiaoVienChuNhiem from tblLop";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertLopHoc(string tl, string nk, int ss, string gvcn)
        {
            string sql = "insert into tblLop values('LP' + cast(next value for LopSeq as nvarchar(50)),N'" + tl + "',N'" + nk + "','" + ss + "',N'" + gvcn + "')";
            //MessageBox.Show(sql);
            da.ExcuteNonQuery(sql);
        }
        public void UpdateLopHoc(string ml, string tl, string nk, int ss, string gvcn)
        {
            string sql = "update tblLop set TenLop=N'" + tl + "', NienKhoa=N'" + nk + "', SiSo='" + ss + "', GiaoVienChuNhiem=N'" + gvcn + "' where MaLop=N'" + ml + "'";
            da.ExcuteNonQuery(sql);//da xong
        }
        public void DeleteLopHoc(string ml)
        {
            string sql = "delete tblLop where MaLop = N'" + ml + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable LookLopHoc(string dk)
        {
            string sql = "select * from tblLop where MaLop like N'%" + dk + "%' OR TenLop like N'%" + dk + "%' OR GiaoVienChuNhiem like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}

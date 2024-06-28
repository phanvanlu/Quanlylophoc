using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_QLSV
{
    class BUS_UC1_QuanLyMonHoc
    {
        Data da = new Data();
        public DataTable ShowMonHoc()
        {
            string sql = "select * from tblMonHoc";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertMonHoc(string tmh, int st)
        {
            string sql = "insert tblMonHoc values('MH' + cast(next value for MonHocSeq as nvarchar(50)),N'" + tmh + "',N'" + st + "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdateMonHoc(string mmh, string tmh, int st)
        {
            string sql = "update tblMonHoc set TenMH=N'" + tmh + "', SoTiet=N'" + st + "' where MaMH=N'" + mmh + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteMonHoc(string mmh)
        {
            string sql = "delete tblMonHoc where MaMH = N'" + mmh + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable LookMonHoc(string dk)
        {
            string sql = "select * from tblMonHoc where MaMH like N'%" + dk + "%' OR TenMH like N'%" + dk + "%' OR SoTiet like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}

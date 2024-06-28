using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DOAN_QLSV
{
    public class BUS_UC1_QuanLyTrinhDo
    {
        Data da = new Data();
        public DataTable ShowTrinhDO()
        {
            string sql = "select * from tblTrinhDo";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        
        public void InsertTrinhDo(string ttd, string cn)
        {
            string sql = "insert tblTrinhDo values('TD' + cast(next value for TrinhDoSeq as nvarchar(20)),N'" + ttd + "',N'" + cn + "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdateTrinhDO(string mtd, string ttd, string cn)
        {
            string sql = "update tblTrinhDo set TenTD=N'" + ttd + "', ChuyenNganh=N'" + cn + "' where MaTD=N'" + mtd + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteTrinhDo(string mtd)
        {
            string sql = "delete tblTrinhDo where MaTD = N'" + mtd + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable LookTrinhDo(string dk)
        {
            string sql = "select * from tblTrinhDo where MaTD like N'%" + dk + "%' OR TenTD like N'%" + dk + "%' OR ChuyenNganh like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}

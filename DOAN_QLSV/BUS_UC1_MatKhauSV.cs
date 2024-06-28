using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DOAN_QLSV
{
    class BUS_UC1_MatKhauSV
    {
        Data da = new Data();

        public DataTable ShowMatKhau()
        {
            string sql = "select * from tblMatKhau";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowHoTenSV(string masv)
        {
            string sql = "select * from tblSinhVien where MaSV = N'"+masv+"'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowMSSV()
        {
            string sql = "select * from tblSinhVien";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertMatKhau(string mk, string tk, string msv)
        {
            string sql = "insert into tblMatKhau values('mksv' + cast(next value for MatKhauSVSeq as nvarchar(50)),N'" + tk + "',N'" + msv + "')";
            //MessageBox.Show(sql);
            da.ExcuteNonQuery(sql);
        }

    }
}

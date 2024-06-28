using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLSV
{
    class BUS_UC0_DoiMatKhau
    {
        Data da = new Data();
        public void DoiMatKhau(string taikhoan, string matkhaumoi)
        {
            string sql = "update tblQuanLy set MatKhau='" + matkhaumoi + "' where MaTaiKhoan = '" + taikhoan + "'";
            da.ExcuteNonQuery(sql);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLSV
{
    class BUS_UC0_DangNhap
    {
        Data da = new Data();

        public bool checkLogin(string uname, string pass)
        {
            string sql = "select * from tblQuanLy where MaTaiKhoan='" + uname + "' and MatKhau = '" + pass + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            if (dt.Rows.Count == 0) return false;
            return true;
        }

        public bool isAdmin(string uname, string pass)
        {
            string sql = "select * from tblQuanLy where MaTaiKhoan='" + uname + "' and MatKhau = '" + pass + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            if (dt.Rows.Count == 0) return false;
            return true;
        }
    }
}

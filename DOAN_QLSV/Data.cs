using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data;
namespace DOAN_QLSV
{
    public class Data
    {
        public DataTable GetTable(string sql)
        {
            string chuoiketnoi = "data source = DESKTOP-6087OJT\\SQLEXPRESS; initial catalog = QUANLYSINHVIEN; integrated security = sspi";
            SqlConnection con = new SqlConnection(chuoiketnoi);
            //SqlConnection con = getConnect();
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
        public void ExcuteNonQuery(string sql)
        {
            string chuoiketnoi = "data source = DESKTOP-6087OJT\\SQLEXPRESS; initial catalog = QUANLYSINHVIEN; integrated security = sspi";
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Connection = con;
            //MessageBox.Show(sql);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }

        public bool check(string sql)
        {
            string chuoiketnoi = "data source = DESKTOP-6087OJT\\SQLEXPRESS; initial catalog = QUANLYSINHVIEN; integrated security = sspi";
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;//tồn tại
            }
            else
            {
                return false;//chưa tồn tại
            }
        }
    }
}

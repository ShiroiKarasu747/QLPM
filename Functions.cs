using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyPhongMay
{
    class Functions
    {
        public static SqlConnection con;

        public static void connect()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-L3MR5NP\SQLEXPRESS;Initial Catalog=QlyPhongMay;Integrated Security=True";
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối thành công");
            }
            else
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
        public static void disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }

        public static DataTable getdatatotable(string sql)
        {
            SqlDataAdapter adt = new SqlDataAdapter(sql, con);
            DataTable tbl = new DataTable();
            adt.Fill(tbl);
            return tbl;
        }

        public static bool CheckKey(string sql)
        {
            SqlDataAdapter adt = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            adt.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        public static void RunSQL(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi dữ liệu các khóa");
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
    }
}

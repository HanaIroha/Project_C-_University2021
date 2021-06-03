using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuVien.DAL
{
    class DataConnection
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=HAIKHANH\SQLEXPRESS;Initial Catalog=QLThuVienWindows;Integrated Security=True");
        }
        public DataTable GetTable(String sql)
        {
            try
            {
                SqlConnection con = GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
                return null;
            }
        }

        public void ExecuteNonQuery(String sql)
        {
            try
            {
                SqlConnection connect = GetConnection();
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public void ExecuteNonQueryWithImage(String sql, byte[] image)
        {
            try
            {
                SqlConnection connect = GetConnection();
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.Add(new SqlParameter("@image", image));
                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}

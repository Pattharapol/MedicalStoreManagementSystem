using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Code
{
    public class DataAccessLayer
    {
        private static SqlConnection conn;

        public static SqlConnection ConOpen()
        {
            if(conn == null)
            {
                conn = new SqlConnection("Data Source=pattharapol-pc\\sqlexpress;Initial Catalog=MedicalStore;Integrated Security=True");
            }
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }

        public static void Execute(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, ConOpen());
            cmd.ExecuteNonQuery();
        }

        public static DataTable Retreiving(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, ConOpen());
            da.Fill(dt);
            return dt;
        }
    }
}

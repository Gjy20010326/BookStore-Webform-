using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BookStore.DAL
{
    
    public class SqlHelper
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public static int ExecuteNonQuery(string sql,SqlParameter[] sp)
        {
            using (SqlConnection conn=new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql,conn))
                {
                    if (sp!=null)
                    {
                        cmd.Parameters.AddRange(sp);
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public static DataTable Query(string sql,SqlParameter[] sp)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql,connStr))
            {
                if (sp!=null)
                {
                    adapter.SelectCommand.Parameters.AddRange(sp);
                }
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}

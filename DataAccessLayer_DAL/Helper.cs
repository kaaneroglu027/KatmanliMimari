using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class Helper
    {
        private SqlConnection cn = null;

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            try
            {
                using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(cmdtext, cn))
                    {
                        //eger parametre bos değilse calıstır
                        if (p != null)
                        {
                            cmd.Parameters.AddRange(p);
                        }
                        OpenConnection();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void OpenConnection()
        {
            if (cn != null && cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
            }
        }
    }
}
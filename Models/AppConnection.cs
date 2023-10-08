using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperRepositoryPattern
{
    internal class AppConnection
    {
        //Get Property(later C# 6.0)
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        // 위의 Property 보다는 이 Property가 편리
        public static SqlConnection Connection
        {
            get
            {
                //var connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                var connection = new SqlConnection(ConnectionString);

                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect to database! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw new Exception("Failed to connect to database.", ex);
                }

                return connection;
            }
        }
    }
}

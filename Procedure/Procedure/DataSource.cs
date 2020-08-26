using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedure
{
    class DataSource
    {
        private static string strconn = "Data Source=192.168.0.44;Initial Catalog=test_20200824;User ID=test;Password=1234";

        public static SqlConnection GetSqlConnection() 
        {
            SqlConnection conn = new SqlConnection(strconn);

            conn.Open();

            return conn;
        }

        public static void D_Close(SqlConnection conn)
        {
            conn.Close();
        }
    }
}

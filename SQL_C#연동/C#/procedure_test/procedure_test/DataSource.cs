using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace procedure_test
{
    

    class DataSource
    {
        private static string strcon = "Data Source=192.168.0.44;Initial Catalog=test_20200824;User ID=test;Password=1234";
        
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            return con;
        }

        public static void D_Close(SqlConnection conn)
        {
            conn.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace select_insert_delete_update
{
    class DataSource
    {
        private static SqlConnection con = null;
        private static string strcon = "Data Source=192.168.0.44;Initial Catalog=Data_Manipulation;User ID=test;Password=1234"
            ;
        public static SqlConnection sqlConnection()
        {
            con = new SqlConnection(strcon);
            con.Open();
            return con;
        }

        public static void s_Close()
        {
            con.Close();
        }

    }
}

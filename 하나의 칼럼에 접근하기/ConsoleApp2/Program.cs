using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlCommand sqlcomn = new SqlCommand();
            SqlDataReader sd;
            String SQL = "select * from student";

            try
            {
                string connectionString = @"Data Source=192.168.0.44;User ID=test;Password=1234";

                SqlConnection conn = new SqlConnection(connectionString);

                sqlcomn.Connection = conn;
                sqlcomn.CommandText = SQL;
                conn.Open();
                sd = sqlcomn.ExecuteReader();

                //Console.WriteLine(conn.State);


                //Console.WriteLine("가나?");

                while (sd.Read())
                {
                    Console.WriteLine("Group ID :: "+sd["name"].ToString());
                }
            }
            catch(Exception)
            {
                Exception a = new Exception();
                Console.WriteLine(a.Message);
            }

        }
    }
}

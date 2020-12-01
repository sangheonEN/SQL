using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procedure_test
{
    class MainDataSource
    {
        public DataTable doDataTable(string name = "")
        {
            SqlConnection conn = DataSource.GetSqlConnection();
            SqlCommand cmd = new SqlCommand("exec xp_student_select @name", conn);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            DataSource.D_Close(conn);

            return ds.Tables[0];

        }

        public void doInsertStudent(string name, int age, int grade)
        {
            SqlConnection conn = DataSource.GetSqlConnection();
            SqlCommand cmd = new SqlCommand("exec xp_student_insert @name, @age, @grade", conn);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@grade", grade);

            cmd.ExecuteNonQuery();
            
            DataSource.D_Close(conn);

        }

        public void doUpdateStudent(int idx, string name, int age, int grade)
        {
            SqlConnection conn = DataSource.GetSqlConnection();
            SqlCommand cmd = new SqlCommand("exec xp_student_update @name, @age, @idx, @grade", conn);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@idx", idx);
            cmd.Parameters.AddWithValue("@grade", grade);

            cmd.ExecuteNonQuery();

            DataSource.D_Close(conn);

        }

        public void doDeleteTable(int idx)
        {
            SqlConnection conn = DataSource.GetSqlConnection();
            SqlCommand cmd = new SqlCommand("exec xp_student_delete @idx", conn);

            cmd.Parameters.AddWithValue("@idx", idx);

            cmd.ExecuteNonQuery();

            DataSource.D_Close(conn);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedure
{
    class MainDataSource
    {
        public DataTable doSelectStudent(string name = "") //parameter가 안들어오면 ""로 인식함.
        {
            SqlConnection conn = DataSource.GetSqlConnection();
            SqlCommand cmd = new SqlCommand("exec xp_student_select @name", conn);
            cmd.Parameters.AddWithValue("@name", name);        // SQLCommand @name에 name을 넘겨줌!
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            sda.Fill(ds);

            DataSource.D_Close(conn);

            return ds.Tables[0];   //SQL에서 명령해준 Table들의 index!!

            /*
	            select * from student       -- 1번째 Table
	            where name like '%'+@name+'%';  --%는 모든것이라는 뜻 %조% 조가 있는 모든것을 select해라!
            	select * from student;      -- 2번째 Table
              	select idx from student;    -- 3번째 Table
             */

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

            SqlCommand cmd = new SqlCommand("exec xp_student_update @name, @age,@grade,@idx", conn);


            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@grade", grade);
            cmd.Parameters.AddWithValue("@idx", idx);

            cmd.ExecuteNonQuery();

            DataSource.D_Close(conn);

        }

        public void doDeleteStudent(int idx)
        {
            SqlConnection conn = DataSource.GetSqlConnection();

            SqlCommand cmd = new SqlCommand("exec xp_student_delete @idx", conn);

            cmd.Parameters.AddWithValue("@idx", idx);

            cmd.ExecuteNonQuery();

            DataSource.D_Close(conn);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;               

namespace _20200824_student
{
    public partial class Form1 : Form
    {
        int idx; // 글로벌 함수는 알아볼수 있도록 네이밍 g_~~ 이런식

        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += this.dataGridView1_CellClick;  // cellclick 했을때 dataGridView1_CellClick 함수를 불러옴!
            //this.dataGridView1.CellClick += this.dataGridView1_CellClick;

        }

        private void button_select_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DataSources.GetConnection();           //DataSource에 SqlConnection의 생성자와 open()함수를 전역으로 사용할 수 있는 메서드 GetConnection을 만들어놓음

            SqlCommand cmd = new SqlCommand("select * from student", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            DataSources.Close();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DataSources.GetConnection();             //DataSource에 SqlConnection의 생성자와 open()함수를 전역으로 사용할 수 있는 메서드 GetConnection을 만들어놓음

            SqlCommand cmd = new SqlCommand("insert into student" +
                                            "(name, age, idx, grade)" +
                                            "values" +
                                            "(@name, @age, @idx, @grade);", conn);

            cmd.Parameters.AddWithValue("@name", textBox_name.Text);
            cmd.Parameters.AddWithValue("@age", textBox_age.Text);
            cmd.Parameters.AddWithValue("@idx", 200);
            cmd.Parameters.AddWithValue("@grade", comboBox_grade.SelectedItem.ToString());

            cmd.ExecuteNonQuery();

            DataSources.Close();
            MessageBox.Show("저장되었습니다.");

        }

        private void button_sql_select_insert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DataSources.GetConnection();   //DataSource에 SqlConnection의 생성자와 open()함수를 전역으로 사용할 수 있는 메서드 GetConnection을 만들어놓음            

            SqlCommand cmd2 = new SqlCommand("select max(idx)+1 as idx from student", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            int idx = 0;

            idx = int.Parse(dt.Rows[0]["idx"].ToString());

            MessageBox.Show($"idx = {idx}");
            cmd2 = new SqlCommand("insert into student" +
                                 "(name, age, idx, grade)" +
                                 "values" +
                                 "(@name, @age, @idx, @grade);", conn);

            cmd2.Parameters.AddWithValue("@name", textBox_name.Text);
            cmd2.Parameters.AddWithValue("@age", textBox_age.Text);
            cmd2.Parameters.AddWithValue("@idx", idx);
            cmd2.Parameters.AddWithValue("@grade", comboBox_grade.Text);

            cmd2.ExecuteNonQuery();

            DataSources.Close();

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string age = textBox_age.Text;
            string grade = comboBox_grade.Text;

            SqlConnection conn = DataSources.GetConnection();
            SqlCommand cmd = new SqlCommand("update student "+
                                            "set name = @name, age = @age, grade = @grade "+
                                            "where idx = @idx",conn);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@grade", grade);
            cmd.Parameters.AddWithValue("@idx", this.idx);

            cmd.ExecuteNonQuery();
            DataSources.Close();
/*            button_select_Click(null, null);   */       // 함수를 실행할때 필요한 object, event를 null로 두어 곧 바로 버튼1 소스코드를 실행하게함 select되게함
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DataSources.GetConnection();
            SqlCommand cmd = new SqlCommand("delete from student " +
                                            "where idx = @idx", conn);

            //delete from studentwhere idx = @idx;
            //delete from student where idx = @idx;

            cmd.Parameters.AddWithValue("@idx", this.idx);

            cmd.ExecuteNonQuery();
            DataSources.Close();
            object senderdd = null;
            EventArgs edd = null;
            button_select_Click(senderdd, edd);          // 버튼1 소스코드인 전체 select되게함
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //foreach (DataGridViewRow temp in dataGridView1.SelectedRows)            // // SelectedRows : 그리드 뷰 속성 MultiSelect를 true로 하면 SelectedRows 즉, 테이블을 선택한 순서대로 SelectedRows[]배열에 들어간다 그래서 foreach문의 Collection에 넣을 수 있어서 클릭횟수 마다 그 배열의 크기가 횟수씩 증가한다. 
            //{
            //    MessageBox.Show("temp = " + temp.Index);
            //}

            int index = dataGridView1.SelectedRows[0].Index;  // SelectedRows : 그리드 뷰 속성 MultiSelect를 true로 하면 SelectedRows 즉, 테이블을 선택한 순서대로 SelectedRows[]배열에 들어간다!!

            idx = int.Parse(dataGridView1.Rows[index].Cells[2].Value.ToString()); // 전역변수로 선언해서 셀 클릭시 idx를 가지고 수정을 할 수 있도록 해야함.

            // 그리드 뷰의 셀을 클릭하면 해당되는 행의 칼럼의 Cell의 배열에 들어간 것을 행의 순서대로 출력해라!! 조회를 할 수 있는 개념
            Console.WriteLine(dataGridView1.Rows[index].Cells[0].Value.ToString());    
            Console.WriteLine(dataGridView1.Rows[index].Cells[1].Value.ToString());
            Console.WriteLine(dataGridView1.Rows[index].Cells[2].Value.ToString());
            Console.WriteLine(dataGridView1.Rows[index].Cells[3].Value.ToString());

            textBox_name.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox_age.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            comboBox_grade.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();

            //MessageBox.Show(index.ToString());
            //MessageBox.Show("!!");
        }
    }
}

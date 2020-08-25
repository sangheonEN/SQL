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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DataSources.GetConnection();
            conn.ConnectionString = "Data Source=192.168.0.44;Initial Catalog=test_20200824;Persist Security Info=True;User ID=test;Password=1234";
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from student", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            DataSources.Close();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DataSources.GetConnection();
            conn.Open();

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
            SqlConnection conn = DataSources.GetConnection();               
            conn.Open();

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

        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}

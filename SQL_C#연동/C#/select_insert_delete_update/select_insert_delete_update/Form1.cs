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

namespace select_insert_delete_update
{

    public partial class Form1 : Form
    {
        int idx = 0;

        public Form1()
        {
            InitializeComponent();


        }

        private void button_select_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DataSource.sqlConnection();
            SqlCommand cmd = new SqlCommand("select * from Table_ERP2", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            cmd.ExecuteNonQuery();

            DataSource.s_Close();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DataSource.sqlConnection();
            SqlCommand cmd = new SqlCommand("select max(idx)+1 as idx from Table_ERP2",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            DataTable dt = new DataTable();

            dt = ds.Tables[0];                      // Table 0번째를 datatable에 넣어주고

            int idx = 0;

            idx = int.Parse(dt.Rows[0]["idx"].ToString());     // datatable의 한행의 idx 칼럼에 접근해 그 값을 인트형으로 변환하여 저장

            MessageBox.Show($"순서 : {idx} 에 추가되었습니다!!");

            cmd = new SqlCommand("insert into Table_ERP2 " +
                                "(idx, Name, Classification, Company, Inputdate, Price, Location, Num )" +
                                "values " +
                                "(@idx, @Name, @Classification, @Company, @inputdate, @Price, @Location, @Num)",conn);

            cmd.Parameters.AddWithValue("@idx", idx);
            cmd.Parameters.AddWithValue("@Name", textBox_Name.Text);
            cmd.Parameters.AddWithValue("@Classification", textBox_Classification.Text);
            cmd.Parameters.AddWithValue("@Company", textBox_Company.Text);
            cmd.Parameters.AddWithValue("@inputdate", textBox_Inputdate.Text);
            cmd.Parameters.AddWithValue("@Price", textBox_Price.Text);
            cmd.Parameters.AddWithValue("@Location", textBox_Location.Text);
            cmd.Parameters.AddWithValue("@Num", textBox_Num.Text);

            cmd.ExecuteNonQuery();

            DataSource.s_Close();

            object sendera = null;
            EventArgs ee = null;
            button_select_Click(sendera, ee);

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string Name = textBox_Name.Text;
            string Classification = textBox_Classification.Text;
            string Company = textBox_Company.Text;
            int Inputdate = int.Parse(textBox_Inputdate.Text);
            int Price = int.Parse(textBox_Price.Text);
            string Location = textBox_Location.Text;
            int Num = int.Parse(textBox_Num.Text);


            SqlConnection conn = DataSource.sqlConnection();
            SqlCommand cmd = new SqlCommand("update Table_ERP2 " +
                                        "set " +
                                        "Name = @Name, Classification = @Classification, Company = @Company, Inputdate = @Inputdate, Price = @Price,Location = @Location,Num = @Num " +
                                        "where idx = @idx ", conn);

            cmd.Parameters.AddWithValue("@idx", this.idx);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Classification", Classification);
            cmd.Parameters.AddWithValue("@Company", Company);
            cmd.Parameters.AddWithValue("@inputdate", Inputdate);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Location", Location);
            cmd.Parameters.AddWithValue("@Num", Num);

            cmd.ExecuteNonQuery();

            DataSource.s_Close();


            object sendera = null;
            EventArgs ee = null;
            button_select_Click(sendera, ee);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            idx = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());

            textBox_Name.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBox_Classification.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBox_Company.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            textBox_Inputdate.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            textBox_Price.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            textBox_Location.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            textBox_Num.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();

            //Console.WriteLine(dataGridView1.Rows[index].Cells[1].Value.ToString());
            //Console.WriteLine(dataGridView1.Rows[index].Cells[2].Value.ToString());
            //Console.WriteLine(dataGridView1.Rows[index].Cells[3].Value.ToString());
            //Console.WriteLine(dataGridView1.Rows[index].Cells[4].Value.ToString());
            //Console.WriteLine(dataGridView1.Rows[index].Cells[5].Value.ToString());
            //Console.WriteLine(dataGridView1.Rows[index].Cells[6].Value.ToString());
            //Console.WriteLine(dataGridView1.Rows[index].Cells[7].Value.ToString());

            //Console.WriteLine(dataGridView1.Rows[index].Cells[0].Value.ToString());

        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}

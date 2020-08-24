using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;                                // SqlConnection, SqlCommand 등의 객체를 사용하기 위한 using 구문(헤더파일)
using System.Data.SqlClient;                      // SqlConnection, SqlCommand 등의 객체를 사용하기 위한 using 구문(헤더파일)
using System.Diagnostics;

namespace _20200824
{
    //private string stcon
    //    = "Data Source=DESKTOP-DQ1D3DR\SQLEXPRESS;User ID = test; Password=1234";
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();    // sql 서버에 연결하는 객체
            conn.ConnectionString = @"Data Source=192.168.0.44;Initial Catalog=test_20200824;Persist Security Info=True;User ID=test;Password=1234";
            conn.Open(); // Open() : 데이터베이스를 열어줘야 다른 사람이 못씀
            SqlCommand cmd = new SqlCommand("select * from a", conn); // sql에서 명령어를 쓴다. select 명령어를 통해 a테이블을 cmd에 담아 놓음
            SqlDataAdapter sda = new SqlDataAdapter(cmd); //SqlDataAdapter는 가져온 데이타를 메모리상의 데이타 객체인 DataSet에 할당한다.
            DataSet ds = new DataSet();

            sda.Fill(ds); // 오버로드 : 같은 행의 

            dataGridView1.DataSource = ds.Tables[0];

            conn.Close();                // 데이터 베이스 연결 끊음.


        }

        private void button5_Click(object sender, EventArgs e)     // 학년 바꾸기
        {
            this.comboBox_grade.Items.Clear();                               // 버튼 누를때 Clear(): 항목을 전부 초기화 시킴
            this.comboBox_grade.Items.AddRange(new object[] {                // form1.Designer에서 ComboBox의 항목편집에서 학녀을 추가한 뒤 AddRange메서드가 생성되면 그것을 붙여넣기해서 함
            "5",
            "6",
            "7",
            "8"});
        }

        private void button2_Click(object sender, EventArgs e)     // insert button
        {
            SqlConnection conn = new SqlConnection("Data Source=192.168.0.44;Initial Catalog=test_20200824;Persist Security Info=True;User ID=test;Password=1234");
            conn.Open();

            // sql의 select 명령어를 사용하기 위해 command, dataadapter, dataset, Fill을 사용해야함 
            SqlCommand cmd = new SqlCommand("select max(idx)+1 as idx from stduent;select * from a", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);  // SqlCommand 명령을 한 변수 cmd를 사용하기 위해
            DataSet ds = new DataSet();        // dataset 구성요소 : Table, ds라는 변수에 SqlCommand에서 select한 Table을 저장하고
            sda.Fill(ds);

            DataTable dt = ds.Tables[0];       // DataTable : Table에 접근하여 각 Table의 행에 접근할 수 있음.
            int idx = 0;
            idx = int.Parse(dt.Rows[0]["idx"].ToString());
            //foreach (DataRow dr in dt.Rows)        
            //{
            //    idx = int.Parse(dr["idx"].ToString());
            //}
            MessageBox.Show("idx = " + idx);

            cmd = new SqlCommand("insert into stduent" +
                                "(idx, name, age, grade)" +
                                "values" +
                                "(@idx, @name, @age, @grade); ", conn);     //sql에서 구문(명령어) 'insert into 테이블명' 사용 

            cmd.Parameters.AddWithValue("@idx", idx);
            cmd.Parameters.AddWithValue("@name", text_name.Text);
            cmd.Parameters.AddWithValue("@age", text_age.Text);
            cmd.Parameters.AddWithValue("@grade", comboBox_grade.SelectedItem.ToString());

            cmd.ExecuteNonQuery();    // 

            conn.Close();


            // select max(idx)+1 사용
            //SqlCommand cmd = new SqlCommand("insert into stduent" +
            //                                "(idx, name, age, grade)" +
            //                                "values" +
            //                                "((select max(idx)+1 as idx from stduent), @name, @age, @grade); ", conn);     //sql에서 구문(명령어) 'insert into 테이블명' 사용 

            ////cmd.Parameters.AddWithValue("@idx", idx);
            //cmd.Parameters.AddWithValue("@name", text_name.Text);
            //cmd.Parameters.AddWithValue("@age", text_age.Text);
            //cmd.Parameters.AddWithValue("@grade", comboBox_grade.SelectedItem.ToString());

            //cmd.ExecuteNonQuery();
            //conn.Close();

            //MessageBox.Show("저장되었습니다.");
        }
    }
}

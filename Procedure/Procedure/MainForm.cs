using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procedure
{
    public partial class MainForm : Form
    {

        MainDataSource mds = new MainDataSource();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            dataGridView1.DataSource = mds.doSelectStudent(name);             

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            int age = int.Parse(textBox3.Text);
            int grade = int.Parse(textBox4.Text);
            mds.doInsertStudent(name, age, grade);

            //insert 후 select
            dataGridView1.DataSource = mds.doSelectStudent("");
            MessageBox.Show("저장이 성공했습니다.");


        }

        private void button_update_Click(object sender, EventArgs e)
        {

            mds.doUpdateStudent(int.Parse(textBox8.Text), textBox5.Text, int.Parse(textBox6.Text), int.Parse(textBox7.Text));
            dataGridView1.DataSource = mds.doSelectStudent();

            MessageBox.Show("수정되었습니다.");
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(dataGridView1.SelectedRows[0].Cells[2].Value);  // idx
            //Console.WriteLine(dataGridView1.SelectedRows[0].Cells[0].Value);  // name
            //Console.WriteLine(dataGridView1.SelectedRows[0].Cells[1].Value);  // age
            //Console.WriteLine(dataGridView1.SelectedRows[0].Cells[3].Value);  // grade


            //셀을 클릭했을때 수정 사항하기 위해 선택한 셀의 각 테이블 칼럼의 인덱스에 접근
            string idx = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();    // idx
            string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();   // name
            string age = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();    // age
            string grade = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();  // grade

            textBox5.Text = name;
            textBox6.Text = age;
            textBox7.Text = grade;
            textBox8.Text = idx;

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            mds.doDeleteStudent(int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()));

            dataGridView1.DataSource = mds.doSelectStudent();

        }
    }
}

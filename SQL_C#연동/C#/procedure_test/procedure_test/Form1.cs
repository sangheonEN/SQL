using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procedure_test
{
    public partial class Form1 : Form
    {
        MainDataSource dt = new MainDataSource();
        public Form1()
        {
            InitializeComponent();
        }
        private void button_select_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            dataGridView1.DataSource = dt.doDataTable(name);
            
        }
        private void button_insert_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            int age = int.Parse(textBox3.Text);
            int grade = int.Parse(textBox4.Text);

            dt.doInsertStudent(name, age, grade);

            dataGridView1.DataSource = dt.doDataTable();

            MessageBox.Show("저장 성공");

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string name = textBox5.Text;
            int age = int.Parse(textBox6.Text);
            int grade = int.Parse(textBox7.Text);
            int idx = int.Parse(textBox8.Text);

            dt.doUpdateStudent(idx, name, age, grade);

            dataGridView1.DataSource = dt.doDataTable();

            MessageBox.Show("수정되었습니다.");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string age = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string idx = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string grade = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            textBox5.Text = name;
            textBox6.Text = age;
            textBox7.Text = grade;
            textBox8.Text = idx;

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int idx = int.Parse(textBox8.Text);

            dt.doDeleteTable(idx);

            dataGridView1.DataSource = dt.doDataTable();

            MessageBox.Show("삭제 완료");

        }
    }
}

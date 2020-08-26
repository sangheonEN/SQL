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

        }
    }
}

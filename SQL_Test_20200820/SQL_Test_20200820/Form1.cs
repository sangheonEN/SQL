using SQL_Test_20200820.mysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Test_20200820;

namespace SQL_Test_20200820
{
    public partial class Form1 : Form
    {

        public A a = null; // A 클래스의 생성자를 만들기 위해 a라는 참조 변수(A클래스의 변수를 변수 형태로 사용하기 위해서)를 생성
        public B b = null;
        public int c = 0;

        public A aa = null;

        public Form1()
        {
            InitializeComponent();
            this.a = new A();
            this.b = new B();

            a.DoA();
        }

        private void btn1_click(object sender, EventArgs e)
        {
            aa = new A();
            if (aa != null)
            {
                MessageBox.Show($"aa 변수 출력 : {aa}");
            }
            else
            {
                MessageBox.Show($"aa에는 null이 들어 있습니다. = {aa}");
            }
            aa = new A();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"aa.B가 출력될까요? {aa.B}");         // 생성자와 내가 사용하고 싶은 클래스를 사용할 인스턴스를 선언한 후에 인스턴스.??로 접근한다!!
            aa.B = new B();
            Console.WriteLine($"aa.B가 출력될까요? {aa.B}");

            aa.MyString = "asdfasdf";

            Console.WriteLine($"{aa.MyString}");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            myform my = new myform();
            MessageBox.Show("myform을 띄워라!!");
            my.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button newbtn = new Button();

            newbtn.Location = new System.Drawing.Point(20, 20);
            newbtn.Name = "newbtn";
            newbtn.Size = new System.Drawing.Size(100, 100);
            newbtn.TabIndex = 5;
            newbtn.Text = "newbtn";
            newbtn.UseVisualStyleBackColor = true;

            newbtn.Click += Newbtn_Click;

            this.Controls.Add(newbtn);

        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("생성된 새로운 버튼을 눌렀다!!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control temp in Controls)
            {
                if(temp.Equals(button5))
                {
                    MessageBox.Show("button5번출력!!");
                }
                else
                {
                    MessageBox.Show("다른 버튼출력");
                }

            }
        }
    }
}

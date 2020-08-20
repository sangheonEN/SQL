using SQL_Test_20200820.mysql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Test_20200820
{
    public class A
    {
        private int a = 10;
        private int b = 20;
        public void DoA()
        {
            int d = 200;
            Console.WriteLine(this.a + "doA 함수 출력은 클래스 A의 a변수를 출력합니다!");
            Console.WriteLine(this.b + "doA 함수 출력은 클래스 A의 b변수를 출력합니다!");
            MessageBox.Show("DoA 함수를 호출 했습니다.");

        }

        private string myString = null;
        public string MyString { 
            get { return "aa";  }
            set {
                //Console.WriteLine("설정되었다");

                myString = value;
                Console.WriteLine(myString);
            } 
        }

        private B c = null;
        public B B
        {
            get
            {
                //Console.WriteLine("가지고 감");
                return this.c;
            }
            set
            {
                //Console.WriteLine("설정함");
                c = value;
            }
        }
    }
}

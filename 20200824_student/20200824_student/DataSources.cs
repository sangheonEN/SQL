using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200824_student
{
    //SqlConnection 클래스를 이벤트가 있을때 마다 생성하면 연산이 느려지니 하나의 클래스에 합쳐서 사용할 수 있도록!

    class DataSources
    {
        // static으로 선언해서 모든 클래스에서 공유해서 사용할 수 있다.     언제나 프로그램이 실행되면 전역으로 계속 메모리상에 존재하게된다.
        // static 클래스, 변수, 메서드는 계속 static으로 선언되어져야 한다.
        private static SqlConnection con = null;
        private static string strcon = "Data Source=192.168.0.44;Initial Catalog=test_20200824;Persist Security Info=True;User ID=test;Password=1234";

        public static SqlConnection GetConnection()
        {
            //DataSources ds = new DataSources();
            //con = new SqlConnection(ds.strcon);
            con = new SqlConnection(strcon);
            con.Open();
            return con;
        }

        public static void Close()
        {
            con.Close();
        }

    }
}

//17줄 private string strcon = "Data Source=192.168.0.44;Initial Catalog=test_20200824;Persist Security Info=True;User ID=test;Password=1234";
/*static을 붙이면 전역으로 사용가능한데 static안쓸려면 GetConnection메서드에서 DataSources ds = new DataSources(); 생성자를 새로 만들어서 strcon을 사용해야함*/

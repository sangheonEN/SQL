using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle_Class.util
{
    class Menu
    {
        public int showmenu()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("오라클 데이터 관리 프로그램 v1.0");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. 테이블 생성");
            Console.WriteLine("2. 테이블 삭제");
            Console.WriteLine("3. 생성 데이터 추가");
            Console.WriteLine("4. 랜덤 생성 데이터 추가");
            Console.WriteLine("5. 전체 데이터 보기");
            Console.WriteLine("6. 프로그램 종료");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("메뉴를 선택하세요.");

            int menu = int.Parse(Console.ReadLine());

            return menu;

        }

    }
}

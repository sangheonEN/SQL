using System;

namespace _20200831_1
{
    class Box
    {
        // 2. 겟터 셋터 방식
        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set {
                Console.WriteLine("셋터 함수를 통해서 height 설정");
                height = value; 
            }
        }

        // 1 생성자 방식으로 private 변수 초기화
        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void Area()
        {
            Console.WriteLine("넓이는 " + this.height * this.width + "입니다");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(300, 500);
            box1.Area();
            box1.Width = 200;
            box1.Area();
            Box box2 = new Box(4, 6);
            box2.Area();
            box2.Height = 10;
            box2.Area();
        }
    }
}

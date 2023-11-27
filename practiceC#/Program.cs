// See https://aka.ms/new-console-template for more information

using System;
using U

namespace HelloWrold
{   
    class Print
    {
        public void PrintOut(string str)
        {
            Console.WriteLine(str);
        }

        delegate void PrintDelegate(string str);
    }

    delegate void PrintDelegate(string str);
    class Program
    {
        static void Main(string[] args)
        {
            String name = "이재관";
            char exmark = '!';

            Console.WriteLine($"제 이름은 {name}입니다{exmark}");
            Console.WriteLine("뭐라는겨");

            Console.WriteLine("이름을 입력하세요: ");
            string? inputName = Console.ReadLine();
            Console.WriteLine($"내 이름은 {inputName}이야!");

            /**
             * 코딩 순서
             * (1) 함수를 사용하기 전에 함수를 가진 클래스의 인스턴스 생성
             * (2) 델리게이트의 객체 생성
             * (3) 델리게이트 호출
             */
            Print p = new Print(); 
            PrintDelegate pdg  = p.PrintOut;
            pdg("델리게이트 호출 성공!");
            
            Console.WriteLine("숫자를 입력하세요");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num);
        }
    }
    

}


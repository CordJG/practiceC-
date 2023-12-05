// See https://aka.ms/new-console-template for more information

using System;
using ConsoleApp2;
using practiceC_;
using KioskProgram;
using System.Diagnostics;


namespace HelloWrold
{

    delegate void PrintDelegate(string str);
    class Program
    {
        static void Main(string[] args)
        {
            /* String name = "이재관";
             char exmark = '!';

             Console.WriteLine($"제 이름은 {name}입니다{exmark}");
             Console.WriteLine("뭐라는겨");

             Console.WriteLine("이름을 입력하세요: ");
             string? inputName = Console.ReadLine();
             Console.WriteLine($"내 이름은 {inputName}이야!");*/

            /**
             * 코딩 순서
             * (1) 함수를 사용하기 전에 함수를 가진 클래스의 인스턴스 생성
             * (2) 델리게이트의 객체 생성
             * (3) 델리게이트 호출
             */
            /* Print p = new Print(); 
             PrintDelegate pdg  = p.PrintOut;
             pdg("델리게이트 호출 성공!");

             ConsoleApp2.Program.Main(); // 다른 클래스 참조

             PrintTxt pt = new PrintTxt();
             pt.Print("외부 클래스 호출");


             PrintName pn = new PrintName();
             pn.Print(inputName);*/

           

            Console.WriteLine("실행하기 원하는 프로그램 번호를 입력해주세요");
            Console.WriteLine("1. 테트리스 실행하기 ,  2. 키오스크 프로그램 실행하기");

            string tetrisAppPath = @"C:\Users\wjrmf\Downloads\테트리스 마무리\bin\Debug\도형 이동.exe";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = tetrisAppPath,
                UseShellExecute = true
            };

            if (int.TryParse(Console.ReadLine(), out int menuChoice))
            {
                switch (menuChoice)
                {
                    case 1:
                        Process.Start(psi);
                        break;

                    case 2:
                        KioskProgram.Program.Main();
                        break;

                    default:
                        Console.WriteLine("잘못된 입력입니다. 다시 실행해주세요");
                        break;
                       
                }
            }
            
        }
    }
    

}


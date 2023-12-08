// See https://aka.ms/new-console-template for more information

using System;
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
            

           

            Console.WriteLine("실행하기 원하는 프로그램 번호를 입력해주세요");
            Console.WriteLine("1. 테트리스 실행하기 ,  2. 키오스크 프로그램 실행하기");

            

            if (int.TryParse(Console.ReadLine(), out int menuChoice))
            {
                switch (menuChoice)
                {
                    case 1:
                        string tetrisAppPath = @"C:\Users\wjrmf\Downloads\테트리스 마무리\bin\Debug\도형 이동.exe";

                        ProcessStartInfo psi = new ProcessStartInfo
                        {
                            FileName = tetrisAppPath,
                            UseShellExecute = true
                        };
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


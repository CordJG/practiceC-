// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace practiceC_
{
    class Program
    {   
        
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {

            Profile[] arrProfile =
            {
                new Profile() {Name = "이재관" , Height = 50},
                new Profile() {Name = "고양이" , Height=30},
                new Profile() {Name = "강아지" , Height = 100},
                new Profile() {Name = "이문세" , Height = 179}

            };
            var profiles = from profile in arrProfile
                           where profile.Height < 170
                           orderby profile.Height
                           select profile;

            foreach ( var profile in profiles)
            {
                Console.WriteLine("{0}, {1}",
                    profile.Name, profile.Height);

            }

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = from n in numbers
                         where n % 2 == 0
                         orderby n
                         select n;

            foreach (int n in result)
            {
                Console.WriteLine("짝수 : {0}", n);
            }

            MyNotifier myNotifier = new MyNotifier();
            myNotifier.SomethingHappened += new EventHandler(MyHandler);
            for (int i = 1; i < 30; i++)
            {
                myNotifier.DoSomething(i);
            }

            Console.WriteLine("실행하기 원는 프로그램 번호를 입력해주세요");
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


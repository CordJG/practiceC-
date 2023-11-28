

using System;
using MyDLL;

namespace DLLDemo
{

    class Program
    {
        private static void Main()
        {
            Console.Write("숫자를 하나 입력하세요: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("숫자를 하나 더 입력하세요 : ");
            double y = Convert.ToDouble(Console.ReadLine());

            //MyDLL 파일 만에 있는 클래스 MyCal의 인스턴스를 생성한다.
            MyCal mc = new MyCal();

            //MyDLL 파일 안에 있는 함수들을 이용해 연산을 한다.
            Console.WriteLine($"{x} + {y} = {mc.Add(x, y)}");
            Console.WriteLine($"{x} - {y} = {mc.Subtract(x,y)}");
            Console.WriteLine($"{x} * {y} = {mc.Multiply(x,y)}");
            Console.WriteLine($"{x} / {y} = {mc.Divide(x,y)}");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    delegate void EventHandler(string message);
    internal class MyNotifier
    {
        public event EventHandler SomthingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                SomthingHappened(String.Format("{0} : 짝", number));
            }
        }
    }

    public struct MyStruct
    {
        int num;
        public MyStruct(int num) { }
    }
}

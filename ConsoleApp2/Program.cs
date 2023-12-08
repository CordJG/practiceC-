// See https://aka.ms/new-console-template for more information


namespace ConsoleApp2
{   
    public class Program
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static public void MySecondHandler(string message)
        {
            Console.WriteLine(message);
        }
        public static void Main(string[] args)

        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomthingHappened += new EventHandler(MyHandler);
            notifier.SomthingHappened += new EventHandler(MySecondHandler);
            for (int i = 1; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}


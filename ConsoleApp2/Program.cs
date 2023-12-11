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

            FileStream fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int value = int.Parse(sr.ReadLine());
            float value2 = float.Parse(sr.ReadLine());
            string str1 = sr.ReadLine();
            sr.Close();
            Console.WriteLine("{0} {1} {2}", value, value2, str1);
            for (int i = 1; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}


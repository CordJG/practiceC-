// See https://aka.ms/new-console-template for more information

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
    

}


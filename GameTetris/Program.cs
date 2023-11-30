
class TETRISSCREEN
{
    List<List<int>> List = new List<List<int>>();

    TETRISSCREEN(int _X, int _Y)
    {

    }
}

namespace Testris{

internal class Program
{
    private static void Main(string[] args)
    {
        for (int y = 0; y < 15; y++)
        {
            for (int i = 0; i < 10; i++)
            {
                if (y == 0 || y == 14)

                {
                    Console.Write("--");
                    
                } else
                {
                    Console.Write("□");
                }
            }

            Console.WriteLine("");
        }

        Console.CursorLeft = 6;
        Console.CursorTop = 6;
        Console.Write("■");
    }
}
}
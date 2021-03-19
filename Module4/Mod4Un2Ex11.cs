using System;

namespace Module4Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Цикл do-while");
            int t = 0;

            do
            {
                Console.WriteLine(t);

                Console.WriteLine("Write ur fav color");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Ur color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Ur color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Ur color is cyan!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Ur color is not in this list!");
                        break;
                }

                t++;
            } while (t < 5);
        }
    }
}

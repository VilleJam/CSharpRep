using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int posSumm = 0;

            foreach (var item in arr)
            {

                if (item > 0)
                    posSumm++;
            }

            Console.WriteLine(posSumm);

            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
                {

                }

            }
        }
    }
}

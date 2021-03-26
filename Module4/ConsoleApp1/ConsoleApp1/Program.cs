using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int posSumm = 0;

            int num;

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
                    for (int j = i + 1; j < arr.GetUpperBound(1) + 1; j++)
                    {
                        if (arr[i, k] > arr[i, j])
                        {
                            num = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = num;
                        }
                    }
                }
            }

            for (int q = 0; q < arr.GetUpperBound(0) + 1; q++)
            {
                for (int w = 0; w < arr.GetUpperBound(1) + 1; w++)
                    Console.Write(arr[q, w] + " ");

                Console.WriteLine();

            }
        }
    }
}

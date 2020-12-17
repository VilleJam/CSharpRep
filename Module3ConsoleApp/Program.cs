using System;

namespace Module3ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Andrey";
            byte MyAge = 27;
            bool HaveIAPet = true;
            double MyShoesSize = 42.0;
            string name = "q";
            int age = 2;
            string favcolor = "white";

            Console.WriteLine($"My name is {MyName}");
            Console.WriteLine("My age is " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIAPet);
            Console.WriteLine("My shoes size is " + MyShoesSize);
            Console.WriteLine("\tПривет,\n мир!");
            Console.WriteLine("{0}\n{1}\n{2}", name, age, favcolor);
            Console.ReadKey();
        }
    }
}

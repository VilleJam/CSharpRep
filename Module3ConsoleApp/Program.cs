using System;

namespace Module3ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = Convert.ToByte(Console.ReadLine());           
            Console.WriteLine("Your name is {0} and age is {1}", name, age);
            Console.Write("Enter your birthdate: ");
            string bdate = Console.ReadLine();
            Console.WriteLine("Your birthdate is: {0}", bdate);
            Console.ReadKey();
        }
    }
}

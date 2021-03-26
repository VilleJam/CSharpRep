using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;
            Console.WriteLine("Введите ваше имя:");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст цифрами:");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);
        }
    }
}

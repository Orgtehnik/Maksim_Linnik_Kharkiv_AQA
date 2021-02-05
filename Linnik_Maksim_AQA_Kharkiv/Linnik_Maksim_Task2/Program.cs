using System;

namespace Linnik_Maksim_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string name = "Вячеслав";
                Console.WriteLine("Введите имя:");
                string str = Console.ReadLine();
                if (str.Equals(name))
                {
                    Console.WriteLine(str + ", " + "Привет!");
                    Console.WriteLine("\n" + new string('-', 20));
                }
                else
                {
                    Console.WriteLine("Нет такого имени");
                    Console.WriteLine("\n" + new string('-', 20));
                }
            }
        }
    }
}

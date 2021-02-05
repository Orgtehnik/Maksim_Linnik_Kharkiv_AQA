using System;

namespace Linnik_Maksim_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число:");
                string str = Console.ReadLine();
                if (Int32.TryParse(str, out int x))
                {
                    if (x >= 7)
                    {
                        Console.WriteLine("Привет");
                        Console.WriteLine("\n" + new string('-', 20));
                    }
                    else
                    {
                        Console.WriteLine("Число меньше 7");
                        Console.WriteLine("\n" + new string('-', 20));
                    }
                }
                else
                {
                    Console.WriteLine("Ввод данных неверный, попробуйте снова");
                    Console.WriteLine("\n" + new string('-', 20));
                }
            }
        }
    }
}

using System;

namespace Linnik_Maksim_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\nВведите размер массива");
                string str = Console.ReadLine();
                try
                {
                    int arrlen = Convert.ToInt32(str);
                    int[] nums = new int[arrlen];
                    for (int i = 0; i < arrlen; i++)
                    {
                        Console.WriteLine($"Введите число массива с индексом {i}");
                        string strnum = Console.ReadLine();
                        int num = Convert.ToInt32(strnum);
                        nums[i] = num;
                    }
                    Console.WriteLine("Элементы массива кратные 3");
                    for (int y = 0; y < arrlen; y++)
                    {
                        if (nums[y] % 3 == 0)
                        {
                            Console.WriteLine($"Index elem {y}: value {nums[y]}");
                        }
                    }
                    Console.WriteLine("\n" + new string('-', 20));
                }
                catch (Exception)
                {

                    Console.WriteLine("Неверный ввод данных");
                    Console.WriteLine("\n" + new string('-', 20));
                }
            }
        }
    }
}

using System;

namespace Practice_20_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1:\n");
            Exercise1();
            Console.WriteLine("\nЗадача 2:\n");
            Exercise2();
        }
        static void Exercise1()
        {
            Console.WriteLine("Введите имя и фамилию:");
            string fullname = Console.ReadLine();
            Console.WriteLine($"Ваше имя и фамилия: {fullname}");
        }
        static void Exercise2()
        {
            Console.WriteLine("Сколько чисел вы хотите?");
            string cntString = Console.ReadLine();
            int cnt;
            int sum = 0;
            if (int.TryParse(cntString, out cnt))
            {
                if (cnt > 0)
                {
                    int[] numbers = new int[cnt];
                    for (int i = 0; i < cnt;)
                    {
                        Console.WriteLine($"Введите число номер {i + 1}:");
                        if (int.TryParse(Console.ReadLine(), out numbers[i]))
                        {
                            sum += numbers[i];
                            i++;
                        }
                    }
                }     
            }
            Console.WriteLine($"Сумма чисел {sum}");
        }
    }
}

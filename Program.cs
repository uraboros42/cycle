using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1: первые 10 чисел Фибоначчи
            Console.WriteLine("Задание 1: первые 10 чисел Фибоначчи");
            int a = 0, b = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a);
                int temp = a;
                a = b;
                b = temp + b;
            }

            Console.WriteLine();

            // Задание 2: чётные числа от 2 до 20
            Console.WriteLine("Задание 2: чётные числа от 2 до 20");
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // Задание 3: таблица умножения от 1 до 5
            Console.WriteLine("Задание 3: таблица умножения от 1 до 5");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Задание 4: ввод пароля с помощью do-while
            Console.WriteLine("Задание 4: введите пароль");
            string password = "qwerty";
            string input;
            do
            {
                Console.Write("Пароль: ");
                input = Console.ReadLine();
                if (input != password)
                {
                    Console.WriteLine("Неверный пароль, попробуйте снова.");
                }
            } while (input != password);

            Console.WriteLine("Пароль принят.");
        }
    }
}

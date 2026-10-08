using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Объявляем массив вёрст патрулирования
            int[] verstsCovered = { 15, 22, 18, 30, 25 };

            Console.WriteLine("--- Патрулирование границы ---");
            for (int i = 0; i < verstsCovered.Length; i++)
            {
                Console.WriteLine($"Выезд {i + 1}: {verstsCovered[i]} вёрст");
            }

            // Алгоритмически находим максимум (без встроенных функций)
            int maxVersts = verstsCovered[0];
            for (int i = 1; i < verstsCovered.Length; i++)
            {
                if (verstsCovered[i] > maxVersts)
                {
                    maxVersts = verstsCovered[i];
                }
            }

            Console.WriteLine($"\nСамый дальний выезд: {maxVersts} вёрст");

            Console.ReadKey(); // Чтобы консоль не закрылась сразу (можно убрать для автопроверки)
        }
    }
}
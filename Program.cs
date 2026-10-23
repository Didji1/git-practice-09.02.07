using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Консольный калькулятор");

            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 - num2;
            if (num2 == 0)
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно!");
            }
            else
            {
                double divResult = num1 / num2;
                Console.WriteLine($"Результат деления: {divResult}");
            }

            double result = num1 - num2;
            Console.WriteLine($"Результат fdasd: {result}");

            Console.WriteLine($"Результат вычитания: {result}");
            double result = num1 / num2;
            Console.WriteLine($"Результат деления {result}");

            Console.ReadLine();
        }
    }
}

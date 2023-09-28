using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string sign;

                Console.WriteLine("Введите первое число");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число");
                secondValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                sign = Console.ReadLine();

                switch (sign)
                {
                    case "+":
                        Console.WriteLine("Результат: " + (firstValue + secondValue));
                        break;
                    case "-":
                        Console.WriteLine("Результат: " + (firstValue - secondValue));
                        break;
                    case "*":
                        Console.WriteLine("Результат: " + (firstValue * secondValue));
                        break;
                    case "/":
                        if (secondValue == 0)
                        {
                            Console.WriteLine("Ошибка, на ноль делить нельзя");
                        }
                        else
                        {
                            Console.WriteLine("Результат: " + (firstValue / secondValue));
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}

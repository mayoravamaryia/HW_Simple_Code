using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Cycle_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Подсчет колличества и суммы четных и нечетных чисел в заданном пользователем диапазоне */

            Console.WriteLine("Enter range of numbers: ");

            int startValue = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            uint evenNumbersCount = 0;
            uint oddNumbersCount = 0;

            int sumEvenNumbers = 0;
            int sumOddNumbers = 0;

            while (startValue <= limit)
            {
                if (startValue % 2 == 0)
                {
                    evenNumbersCount++;
                    sumEvenNumbers += startValue;
                }
                else
                {
                    oddNumbersCount++;
                    sumOddNumbers += startValue;
                }
                startValue++;
            }

            Console.WriteLine($"Amount of even numbers: {evenNumbersCount}");
            Console.WriteLine($"Amount of odd numbers: {oddNumbersCount}");
            Console.WriteLine($"Sum of even numbers {sumEvenNumbers}");
            Console.WriteLine($"Sum of odd numbers {sumOddNumbers}");
            Console.ReadLine();
        }
    }
}

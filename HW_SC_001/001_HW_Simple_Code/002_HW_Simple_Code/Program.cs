using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HW_Simple_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program that calculates the multiplication and sum of three numbers

            Console.WriteLine("Enter three numbers: ");

            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine()),
                c = int.Parse(Console.ReadLine());

            int multiplicationResult = a * b * c;
            int sumResult = a + b + c;

            Console.WriteLine($"Multiplication result for this numbers is: {multiplicationResult}");
            Console.WriteLine($"Sum result for this numbers is: {sumResult}");

            Console.ReadLine();



        }
    }
}

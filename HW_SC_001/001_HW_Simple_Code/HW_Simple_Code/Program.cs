using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Simple_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program that calculats the arithmetic mean of two numbers

            Console.WriteLine("Enter two numbers: ");

            double value1 = double.Parse(Console.ReadLine()),
                value2 = double.Parse(Console.ReadLine());

            double result = (value1 + value2) / 2;

            Console.WriteLine($"Your result is {result}");

            Console.ReadKey();


        }
    }
}

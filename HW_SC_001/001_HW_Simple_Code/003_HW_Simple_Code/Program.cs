using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_HW_Simple_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Currency converter

            Console.WriteLine("Enter your amount of money: ");

            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Select exchange currency: \"dollar\" or \"euro\"");

            string currency = Console.ReadLine();

            if (currency == "dollar")
            {
                double x = 4.5;
                double result = (double)(amount / x);
                Console.WriteLine($"Your amount of money in dollars is {result}");
            }
            else
            {
                double y = 5.3;
                double result = (double)(amount / y);
                Console.WriteLine($"Your amount of money in euro is {result}");
            }
            Console.ReadLine();
        }
    }
}

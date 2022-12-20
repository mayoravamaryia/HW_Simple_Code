using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_SC_002
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //A program that cheks numbers even

            Console.WriteLine("Enter your number");

            int value = int.Parse(Console.ReadLine());

                        {
                if (value % 2 == 0)
                {
                    Console.WriteLine("Your number is even.");
                    
                }
                else
                {
                    Console.WriteLine("Your number is not even.");
                 
                }
            }
            Console.ReadKey();
        }
    }
}

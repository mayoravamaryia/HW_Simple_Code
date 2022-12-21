using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_HW_SC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter heigth of triangle: ");
            int heigth = int.Parse(Console.ReadLine());
            /*
             *
             **
             ***
             ****
             *****
             
             */

            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /*
             *****
             ****
             ***
             **
             *
            
             */

            for (int i = 0; i < heigth; i++)
            {
                for (int j = heigth; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /*
                 *
                **
               ***
              ****
             *****
             */

            for (int i = 0; i <= heigth; i++)
            {
                for (int j = heigth; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /*
              *****
               ****
                ***
                 **
                  *                          
             */

            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = heigth; k > i; k--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
 }


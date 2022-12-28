using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_SC_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Найти наименьшее число в массиве

            Console.Write("Enter array's legth: ");
            int arraysLength = int.Parse(Console.ReadLine());

            int[] userArray = new int[arraysLength];

            for (int i = 0; i < arraysLength; i++)
            {
                Console.Write($"Enter array's value {i}: ");
                userArray[i] = int.Parse(Console.ReadLine());
            }

            //Console.WriteLine(userArray.Min());
            int min = userArray[0];

            for (int i = 1; i < userArray.Length; i++)
            {
                if (userArray[i] < min)
                {
                    min = userArray[i];
                }
            }
            Console.WriteLine($"{min} is the smallest number of array");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_SC_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Найти сумму четных чисел в массиве

            Console.Write("Enter array's legth: ");
            int arraysLength = int.Parse(Console.ReadLine());

            int[] userArray = new int[arraysLength];

            for (int i = 0; i < arraysLength; i++)
            {
                Console.Write($"Enter array's value {i}: ");
                userArray[i] = int.Parse(Console.ReadLine());
            }
            //Console.WriteLine(userArray.Where(i => i % 2 == 0).Sum());
            int sumOfEvenNumbers = 0;

            for (int i = 0; i < userArray.Length; i++)
            {
                if (userArray[i] % 2 == 0)
                {
                    sumOfEvenNumbers += userArray[i];
                }
            }
            Console.Write($"Sum of even numbers is: {sumOfEvenNumbers}");
            Console.ReadLine();
        }
    }
}

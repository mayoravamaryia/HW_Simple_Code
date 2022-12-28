using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_SC_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вывести массив в обратном порядке

            Console.Write("Enter array's legth: ");
            int arraysLength = int.Parse(Console.ReadLine());

            int[] userArray = new int[arraysLength];

            for (int i = 0; i < arraysLength; i++)
            {
                Console.Write($"Enter array's value {i}: ");
                userArray[i] = int.Parse(Console.ReadLine());
            }
            //Array.Reverse(userArray);

            for (int i = userArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{userArray[i]} ");
            }
            Console.ReadLine();
        }
    }
}

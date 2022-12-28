using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_SC_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Заполнить массив с клавиатуры

            Console.Write("Enter array's legth: ");
            int arraysLength = int.Parse(Console.ReadLine());

            int[] userArray = new int[arraysLength];

            for (int i = 0; i < arraysLength; i++)
            {
                Console.Write($"Enter array's value {i}: ");
                userArray[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < userArray.Length; j++)
                Console.Write($"{userArray[j]} ");

            Console.ReadLine();
        }
    }
}

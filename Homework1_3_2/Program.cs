using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во строчек: ");
            int rows=Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов: ");
            int columns=Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[rows, columns];
            Random random = new Random();
            int randomNumberMin = 1;
            int randomNumberMax = 9;
            int maxElement = int.MinValue;

            for(int row=0; row<array.GetLength(0); row++)
            {
                for (int column=0; column<array.GetLength(1); column++)
                {
                    array[row, column] = random.Next(randomNumberMin, randomNumberMax + 1);
                }
            }

            Console.WriteLine("Исходная матрица:");
            Console.WriteLine();

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write(array[row, column] + " ");
                }

                Console.WriteLine();
            }

            foreach (int arrayElement in array)
            {
                if (maxElement<arrayElement)
                {
                    maxElement= arrayElement;
                }
            }

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    if (array[row, column]== maxElement)
                    {
                        array[row, column] = 0;
                    }
                }
            }

            Console.WriteLine("Наибольшее число: " + maxElement);
            Console.WriteLine("Преобразованная матрица:");
            Console.WriteLine();

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write(array[row, column] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
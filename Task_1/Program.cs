/* Задача 54: Задайте двумерный массив. Напишите программу,
 * которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

//Пузырьком

namespace Task_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] GetArray(int row, int col)
            {
                int[,] array = new int[row, col];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        array[i, j] = new Random().Next(1, 10);
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                return array;
            }

            int[,] DescendingStringInArray(int[,] array)
            {
                int temp = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(1) - 1; k++)
                        {
                            if (array[i, k] < array[i, k + 1])
                            {
                                temp = array[i, k];
                                array[i, k] = array[i, k + 1];
                                array[i, k + 1] = temp;
                            }
                        }
                    }
                }
                return array;
            }

            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            int n;
            int m;

            Console.WriteLine("Введите число строк(n): ");
            bool ifParseOk = int.TryParse(Console.ReadLine(), out n);
            if (!ifParseOk)
            {
                Console.WriteLine("Введено неверное значение");
            }
            Console.WriteLine("Введите число столбцов(m): ");

            bool ifParseOk2 = int.TryParse(Console.ReadLine(), out m);
            if (!ifParseOk2)
            {
                Console.WriteLine("Введено неверное значение");
            }

            PrintArray(DescendingStringInArray(GetArray(n, m)));
        }
    }
}
/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
 * которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка*/

namespace Task_2
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

            string FindStringWithLowestSum(int[,] array)
            {
                string result = string.Empty;
                int maxSum = 0;
                int tempSum = 0;
                string temp = string.Empty;
                string rowNum = string.Empty;

                for (int i = 0; i < array.GetLength(0); i++) //находим максимальную сумму элементов по строкам в двумерном массиве
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        tempSum = tempSum + array[i, j];
                    }
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }
                    tempSum = 0;
                }


                for (int i = 0; i < array.GetLength(0); i++)  //находим строку с минимальной суммой и возвращаем ее элементы
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        tempSum = tempSum + array[i, j];
                        temp += array[i, j] + " ";
                    }
                    if (tempSum < maxSum)
                    {
                        maxSum = tempSum;
                        result = temp;
                        rowNum = Convert.ToString(i);
                    }
                    temp = string.Empty;
                    tempSum = 0;
                }
                return result + "Номер строки с наименьшей суммой элементов: " + rowNum; 
                
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

            
            Console.WriteLine(FindStringWithLowestSum(GetArray(n, m)));
        }
    }
}
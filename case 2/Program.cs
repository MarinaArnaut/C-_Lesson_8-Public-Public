// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArray(int a, int b)
{
    Console.WriteLine("Заданный массив: ");
    int[,] matrix = new int[a, b];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int colums = 0; colums < matrix.GetLength(1); colums++)
        {
            matrix[rows, colums] = new Random().Next(1, 10);
            Console.Write($"{matrix[rows, colums]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

void MinSumRows(int[,] inArray)
{
    int minRowSum = int.MaxValue, indexMinRow = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = sum + inArray[i, j];
        }
        if (sum < minRowSum)
        {
            minRowSum = sum;
            indexMinRow = i + 1;
        }
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {indexMinRow}");
}

Console.WriteLine();
MinSumRows(CreateArray(4, 4));
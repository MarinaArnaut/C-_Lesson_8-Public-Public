// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortedArray(int[,] array)
{
    int row = 0;
    int[] singleArray = new int[array.GetLength(1)];
    while (row < array.GetLength(0))
    {
        for (int colums = 0; colums < array.GetLength(1); colums++)
            singleArray[colums] = array[row, colums];

        Array.Sort(singleArray);
        Array.Reverse(singleArray);

        for (int colums = 0; colums < array.GetLength(1); colums++)
            array[row, colums] = singleArray[colums];

        row++;
    }
    return array;
}

void PrintNewArray(int[,] matrix)
{
    Console.WriteLine("Новый массив, в котором упорядочены по убыванию элементы каждой строки: ");
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int colums = 0; colums < matrix.GetLength(1); colums++)
        {
            Console.Write($"{matrix[rows, colums]} ");
        }
        Console.WriteLine();
    }
}

PrintNewArray(SortedArray(CreateArray(4, 4)));
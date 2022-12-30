// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray(int a, int b);
{
    int a = new Random().Next(1, 10);
    int b = new Random().Next(1, 10);
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

void MultiplicationArray(int[,] matrix1, int[,] matrix2)
{
    int[,] newArray = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int l = 0; 1 < matrix2.GetLength(0); l++)
            {
                newArray[i, j] = matrix1[i, l] * matrix2[l, j] + newArray[i, j];
            }
            Console.Write(newArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array1 = CreateArray(matrix);
int[,] array2 = CreateArray(matrix);
Console.WriteLine();
Console.WriteLine("Произведение двух массивов: ");
MultiplicationArray(array1, array2);
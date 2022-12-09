// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintMatrix(int[,] matrix)
{
    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (var j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] GenerateRandomIntMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int MinimumSumRowNumber(int[,] arr)
{
    int minSum = Int32.MaxValue;
    int minRow = default;
    for (var i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (var j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow + 1;
}

var matrix = GenerateRandomIntMatrix(4, 4, 0, 9);
PrintMatrix(matrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinimumSumRowNumber(matrix)}");


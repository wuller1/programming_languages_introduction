// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7->такого элемента в массиве нет

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

bool InArray(int[,] mat, int row, int column)
{
    if (mat.GetLength(0) > row && mat.GetLength(1) > column)
        return true;
    return false;
}

void PrintElementByIndex(int[,] arr)
{
    Console.Write("Введите индекс строки: ");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите индекс столбца: ");
    int column = Convert.ToInt32(Console.ReadLine());

    if (InArray(arr, row, column))
    {
        Console.WriteLine($"Элемент с индексами ({row}, {column}) в заданном массиве: {arr[row, column]}");
    }
    else
    {
        Console.WriteLine($"Элемент с индексами ({row}, {column}) отсутствует в заданном массиве.");
    }
}

int[,] matrix = GenerateRandomIntMatrix(3, 4, 0, 9);
PrintMatrix(matrix);
PrintElementByIndex(matrix);
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.Write("]\n");
}

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

double[] MatrixColumnsMean(int[,] mat)
{
    int columnsCount = mat.GetLength(1);
    double[] columnsSum = new double[columnsCount];
    double[] columnsMean = new double[columnsCount];
    for (var j = 0; j < columnsCount; j++)
    {
        for (var i = 0; i < mat.GetLength(0); i++)
        {
            columnsSum[j] += mat[i, j];
        }
        columnsMean[j] = Math.Round(columnsSum[j] / (columnsCount - 1), 1);
    }
    return columnsMean;
}

var matrix = GenerateRandomIntMatrix(3, 4, 0, 9);
PrintMatrix(matrix);
var meanArray = MatrixColumnsMean(matrix);
Console.WriteLine("Среднее арифметическое столбцов:");
PrintArray(meanArray);
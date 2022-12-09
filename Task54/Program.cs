// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortMatrixByRows(int[,] arr)
{
    int temp = default;
    bool sorted = false;
    for (var i = 0; i < arr.GetLength(0); i++)
    {

        while (!sorted)
        {
            bool switched = false;
            for (var j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    temp = arr[i, j + 1];
                    arr[i, j + 1] = arr[i, j];
                    arr[i, j] = temp;
                    switched = true;
                }
            }

            if (!switched)
                sorted = true;
        }
        sorted = false;
    }
}

var matrix = GenerateRandomIntMatrix(4, 4, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
SortMatrixByRows(matrix);
PrintMatrix(matrix);
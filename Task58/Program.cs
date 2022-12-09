// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

bool isMultiplicable(int[,] mat1, int[,] mat2)
{
    if (mat1.GetLength(1) == mat2.GetLength(0))
        return true;
    return false;
}

int[,] MultiplyMatrices(int[,] mat1, int[,] mat2)
{
    int[,] resultMatrix = new int[mat1.GetLength(0), mat2.GetLength(1)];
    for (var i = 0; i < mat1.GetLength(0); i++)
    {
        for (var j = 0; j < mat1.GetLength(1); j++)
        {
            for (var col = 0; col < mat2.GetLength(1); col++)
            {
                resultMatrix[i, col] += mat1[i, j] * mat2[j, col];
            }
        }
    }
    return resultMatrix;
}
void PrintMultiplicationResult(int[,] mat1, int[,] mat2)
{
    if (isMultiplicable(mat1, mat2))
    {
        PrintMatrix(MultiplyMatrices(mat1, mat2));
    }
    else
    {
        Console.WriteLine($"Данные матрицы невозможно умножить");
    }
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

var matrix1 = GenerateRandomIntMatrix(3, 2, 0, 9);
var matrix2 = GenerateRandomIntMatrix(2, 4, 0, 9);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
PrintMultiplicationResult(matrix1, matrix2);
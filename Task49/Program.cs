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

int[,] EvenIndices(int[,] mat)
{
    int[,] evenIndicedMatrix = new int[mat.GetLength(0), mat.GetLength(1)];
    for (var i = 0; i < mat.GetLength(0); i++)
    {
        for (var j = 0; j < mat.GetLength(1); j++)
        {
            if (i % 2 != 1 && j % 2 != 1)
            {
                evenIndicedMatrix[i, j] = mat[i, j] * mat[i, j];
            }
            else
            {
                evenIndicedMatrix[i, j] = mat[i, j];
            }
        }
    }
    return evenIndicedMatrix;
}

int[,] matrix = GenerateRandomIntMatrix(3, 4, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[,] evenIndiced = EvenIndices(matrix);
PrintMatrix(evenIndiced);
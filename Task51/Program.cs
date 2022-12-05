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

int MainDiagonalSum(int[,] mat)
{
    int sum = 0;
    for (var i = 0; i < mat.GetLength(0); i++)
    {
        for (var j = 0; j < mat.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += mat[i, j];
            }
        }
    }
    return sum;
}

var matrix = GenerateRandomIntMatrix(3, 4, 0, 9);
var diagonalSum = MainDiagonalSum(matrix);
PrintMatrix(matrix);
Console.WriteLine(diagonalSum);
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

void TransposeSquareMatrix(int[,] arr)
{
    int temp;
    for (var i = 0; i < arr.GetLength(0); i++)
    {
        for (var j = i; j < arr.GetLength(1); j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }

}

var array = GenerateRandomIntMatrix(5, 5, 0, 9);
PrintMatrix(array);
TransposeSquareMatrix(array);
Console.WriteLine();
PrintMatrix(array);
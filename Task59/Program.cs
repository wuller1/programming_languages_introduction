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

int[,] MatrixWithoutMinCross(int[,] mat)
{
    var minDict = MinimiumInMatrix(mat);
    int min = minDict["value"];
    int row = minDict["row"];
    int column = minDict["column"];
    int[,] resultMatrix = new int[mat.GetLength(0) - 1, mat.GetLength(1) - 1];

    int currentRow = 0;
    int currentColumn = 0;

    for (var i = 0; i < mat.GetLength(0); i++)
    {
        if (i == row)
        {
            continue;
        }
        currentColumn = 0;

        for (var j = 0; j < mat.GetLength(1); j++)
        {
            if (j == column)
            {
                continue;
            }
            resultMatrix[currentRow, currentColumn] = mat[i, j];
            currentColumn++;
        }
        currentRow++;
    }
    return resultMatrix;
}

Dictionary<string, int> MinimiumInMatrix(int[,] mat)
{
    int min = Int32.MaxValue;
    int row = 0;
    int column = 0;
    Dictionary<string, int> minimumDictionary = new Dictionary<string, int>();
    for (var i = 0; i < mat.GetLength(0); i++)
    {
        for (var j = 0; j < mat.GetLength(1); j++)
        {
            if (mat[i, j] < min)
            {
                min = mat[i, j];
                row = i;
                column = j;
            }
        }
    }
    minimumDictionary["value"] = min;
    minimumDictionary["row"] = row;
    minimumDictionary["column"] = column;
    return minimumDictionary;
}

int[,] matrix = GenerateRandomIntMatrix(4, 4, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(MatrixWithoutMinCross(matrix));
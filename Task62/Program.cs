// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] FillMatrixSpirally(int[,] arr, int startValue, int startIndex, int endIndex)
{
    int width = (endIndex - startIndex + 1);
    if (width == 1)
    {
        arr[startIndex, endIndex] = startValue;
        return arr;
    }

    if (width == 0)
    {
        return arr;
    }

    for (var i = startIndex; i < endIndex + 1; i++)
    {
        arr[startIndex, i] = startValue++;
    }

    if (width != 2)
    {
        for (var j = startIndex + 1; j < endIndex; j++)
        {
            arr[j, endIndex] = startValue++;
        }
    }


    for (var i = endIndex; i >= startIndex; i--)
    {
        arr[endIndex, i] = startValue++;
    }

    if (width != 2)
    {
        for (var j = endIndex - 1; j >= startIndex + 1; j--)
        {
            arr[j, startIndex] = startValue++;
        }
    }
    return FillMatrixSpirally(arr, startValue, startIndex + 1, endIndex - 1);
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

PrintMatrix(FillMatrixSpirally(new int[4, 4], 1, 0, 3));
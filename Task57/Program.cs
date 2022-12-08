int[] UnwrapMatrix(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int lastNotFilled = 0;
    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        for (var j = 0; j < matrix.GetLength(1); j++)
        {
            arr[lastNotFilled++] = matrix[i, j];
        }
    }
    return arr;
}

Dictionary<int, int> FrequencyDictionary(int[] arr)
{
    Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();
    for (var i = 0; i < arr.Length; i++)
    {
        if (frequencyDictionary.ContainsKey(arr[i]))
        {
            frequencyDictionary[arr[i]] += 1;
        }
        else
        {
            frequencyDictionary[arr[i]] = 1;
        }
    }
    return frequencyDictionary;
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

void PrintArray(int[] array)
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

void PrintFrequency(Dictionary<int, int> dict)
{
    foreach (KeyValuePair<int, int> kvp in dict)
    {
        Console.WriteLine($"{kvp.Key} встречается {kvp.Value} раз");
    }
}

int[,] mat = GenerateRandomIntMatrix(3, 3, 0, 9);
int[] unwrappedMatrix = UnwrapMatrix(mat);
Array.Sort(unwrappedMatrix);
PrintMatrix(mat);
PrintArray(unwrappedMatrix);
PrintFrequency(FrequencyDictionary(unwrappedMatrix));

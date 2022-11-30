void PrintArray(int[] arr)
{
    foreach (var num in arr)
    {
        Console.Write($" {num}");
    }
    Console.WriteLine();
}

int[] FebonacciSequence(int count)
{
    int[] arr = new int[count];
    for (var i = 0; i < count; i++)
    {
        if (i == 0) arr[i] = 0;
        else if (i == 1) arr[i] = 1;
        else arr[i] = arr[i - 2] + arr[i - 1];
    }
    return arr;
}

PrintArray(FebonacciSequence(7));
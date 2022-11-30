void PrintArray(int[] arr)
{
    foreach (var num in arr)
    {
        Console.Write($" {num}");
    }
    Console.WriteLine();
}

int[] CopyArray(int[] arr)
{
    int[] arrCopy = new int[arr.Length];
    for (var i = 0; i < arr.Length; i++)
    {
        arrCopy[i] = arr[i];
    }
    return arrCopy;
}

int[] array = new int[] { 0, 5, 8, 12, 18, 34 };
PrintArray(array);
int[] arrayCopy = CopyArray(array);
arrayCopy[3] = 212;
PrintArray(arrayCopy);
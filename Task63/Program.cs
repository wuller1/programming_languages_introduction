int[] FromOneToN(int[] arr, int from, int to)
{
    arr[from - 1] = from;
    if (to == from)
        return arr;
    from++;
    return FromOneToN(arr, from, to);
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
    Console.Write(" ]\n");
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintArray(FromOneToN(new int[number], 1, number));
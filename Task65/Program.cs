int[] ArrayInRange(int[] arr, int from, int to, int index)
{
    arr[index] = from;
    if (to == from) return arr;

    if (from > to) from--;
    else from++;

    index++;

    return ArrayInRange(arr, from, to, index);
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

Console.Write("Введите начальное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    PrintArray(ArrayInRange(new int[number1 - number2 + 1], number1, number2, 0));
}
else
{
    PrintArray(ArrayInRange(new int[number2 - number1 + 1], number1, number2, 0));
}
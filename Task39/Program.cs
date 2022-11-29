int[] RandomArray(int numOfElements, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] array = new int[numOfElements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
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

void ReverseArray(int[] arr)
{
    int temp;
    for (var i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = arr[i];
        arr[i] = temp;
    }
}

int[] array = RandomArray(11, 0, 10);
PrintArray(array);
ReverseArray(array);
PrintArray(array);
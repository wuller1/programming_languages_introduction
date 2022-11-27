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

int NumberOfTwoDigitNumbers(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99) num += 1;
    }
    return num;
}

var array = RandomArray(123, 10, 99);
PrintArray(array);
Console.WriteLine(NumberOfTwoDigitNumbers(array));
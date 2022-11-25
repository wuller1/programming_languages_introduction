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
    Console.Write("]");
}

int[] SumOfPositiveNegative(int[] array)
{
    int positiveSum = 0;
    int negativeSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positiveSum += array[i];
        else negativeSum += array[i];
    }
    return new int[] { positiveSum, negativeSum };
}

int[] randomArray = RandomArray(12, -9, 9);

Console.Write($"В массиве ");
PrintArray(randomArray);
Console.Write($" сумма отрицательных элементов равна: {SumOfPositiveNegative(randomArray)[1]}, сумма положительных элементов равна: {SumOfPositiveNegative(randomArray)[0]}\n");

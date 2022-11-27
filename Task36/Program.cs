// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateRandomIntArray(int numOfElements, int minValue, int maxValue)
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

int SumOfElementsOnOddIndices(int[] arr)
{
    int sum = 0;
    for (var i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

var array = GenerateRandomIntArray(10, -100, 100);
var sumOfOddIndicedItems = SumOfElementsOnOddIndices(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов, стоящих не нечетных позициях в массиве: {sumOfOddIndicedItems}");

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int NumberOfEvenInArray(int[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

var array = GenerateRandomIntArray(10, 100, 999);
var numberOfEven = NumberOfEvenInArray(array);

PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве: {numberOfEven}");
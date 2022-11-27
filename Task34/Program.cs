// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void PrintDoubleArray(double[] array)
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
    Console.Write($"]\n");
}

double[] GenerateRandomDoubleArray(int length, int min, int max, bool integer = true, int precision = 2)
{
    Random rnd = new Random();
    double[] arr = new double[length];

    for (var i = 0; i < length; i++)
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, precision);
    return arr;

}

PrintDoubleArray(GenerateRandomDoubleArray(10, 0, 10, false));
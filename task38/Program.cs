// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
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

double[] GenerateRandomDoubleArray(int length, int min, int max, int precision = 2)
{
    Random rnd = new Random();
    double[] arr = new double[length];

    for (var i = 0; i < length; i++)
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, precision);
    return arr;

}

double MaxItemInArray(double[] arr)
{
    double max = Double.MinValue;
    for (var i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double MinItemInArray(double[] arr)
{
    double min = Double.MaxValue;
    for (var i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double DifferenceBetweenMaxAndMin(double[] arr)
{
    return Math.Round(MaxItemInArray(arr) - MinItemInArray(arr), 1);
}

var array = GenerateRandomDoubleArray(10, 0, 10, 1);
PrintDoubleArray(array);

var max = MaxItemInArray(array);
var min = MinItemInArray(array);
var difference = DifferenceBetweenMaxAndMin(array);

Console.WriteLine($"В заданном массиве минимальное значение {min}, максимальное значение {max}, разница между максимальным и минимальным значениями: {difference}");

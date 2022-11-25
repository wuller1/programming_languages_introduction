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

bool InArray(int value, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (value == arr[i]) return true;
    }
    return false;
}

var array = RandomArray(12, 0, 10);
int val = 3;
string msg = InArray(val, array) ? "Да" : "Нет";
PrintArray(array);
Console.WriteLine(msg);
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

int[] ProductOfPairs(int[] arr)
{
    int productLength = arr.Length % 2 == 0 ? arr.Length / 2 : arr.Length / 2 + 1;
    int[] products = new int[productLength];

    for (int i = 0; i < productLength; i++)
    {
        if (i == arr.Length - i - 1) products[i] = arr[i];
        else products[i] = arr[i] * arr[arr.Length - i - 1];
    }
    return products;
}

var array = RandomArray(10, 0, 10);
PrintArray(array);
var productArray = ProductOfPairs(array);
PrintArray(productArray);

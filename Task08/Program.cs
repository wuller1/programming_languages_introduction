Console.Write("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0 && i != number && i != number - 1)
    {
        Console.Write($"{i}, ");
    }
    else if (i % 2 == 0)
    {
        Console.Write($"{i}");
    }
}
Console.WriteLine();
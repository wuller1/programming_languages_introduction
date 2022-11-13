Console.Write("Введите целое число: ");
var number = Convert.ToInt32(Console.ReadLine());

for (var i = -number; i <= number; i++)
{
    if (i != number)
    {
        Console.Write($"{i}, ");
    }
    else
    {
        Console.Write($"{i}");
    }
}
Console.WriteLine();

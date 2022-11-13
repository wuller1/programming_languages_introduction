Console.Write("Введите целое число: ");
var number = Convert.ToInt32(Console.ReadLine());

for (var i = -number; i < number + 1; i++)
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

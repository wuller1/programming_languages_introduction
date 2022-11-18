int number = -1;
while (number < 0)
{
    Console.Write("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

void PrintSquareTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i}\t{i * i}");
    }
}

PrintSquareTable(number);
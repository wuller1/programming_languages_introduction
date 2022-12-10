// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumFromTo(int from, int to)
{
    if (from > to)
    {
        int temp = from;
        from = to;
        to = temp;
    }

    if (from != to)
    {
        return from + SumFromTo(++from, to);
    }
    return to;
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumFromTo(number1, number2));
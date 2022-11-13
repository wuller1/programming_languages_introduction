// See https://aka.ms/new-console-template for more information
Console.Write("Введите первое число: ");
var number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите второе число: ");
var number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (number2 * number2 == number1)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}


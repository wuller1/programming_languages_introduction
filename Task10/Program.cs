// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
var number = Convert.ToInt32(Console.ReadLine());

while (number < 100 || number > 999)
{
    Console.Write("Введите трехзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
int secondNumber = (number % 100) / 10;
Console.WriteLine($"Вторая цифра числа {number} - {secondNumber}");
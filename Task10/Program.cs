// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number;
do
{
    Console.Write("Введите трехзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
while (number < 100 || number > 999);
int secondNumber = (number % 100) / 10;
Console.WriteLine($"Вторая цифра числа {number} - {secondNumber}");
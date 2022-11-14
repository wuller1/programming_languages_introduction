// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine($"В числе {number} нет третьей цифры");
}
else
{
    Console.WriteLine($"Третья цифра числа {number} - {Convert.ToString(number)[2]}");
}



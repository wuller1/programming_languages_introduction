// See https://aka.ms/new-console-template for more information
Console.Write("Введите целое число: ");
var number = Convert.ToInt64(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Число {number} в квадрате равно: {number * number}");
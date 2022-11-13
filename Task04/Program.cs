// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int maxNumber = Int32.MinValue;
int inputNumber;

for (int i = 0; i < 3; i++)
{
    Console.Write($"Введите {i + 1}-е число: ");
    inputNumber = Convert.ToInt32(Console.ReadLine());
    if (inputNumber > maxNumber) maxNumber = inputNumber;
}

Console.WriteLine($"Максимальное число: {maxNumber}");
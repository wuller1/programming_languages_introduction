// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Power(int number, int power)
{
    double poweredNumber = 1;

    for (int i = 0; i < Math.Abs(power); i++)
        poweredNumber = power >= 0 ? poweredNumber * number : poweredNumber / number;

    return poweredNumber;
}

int PositiveIntegerPower(int number, int power)
{
    if (power < 0) return -1;

    int poweredNumber = 1;

    for (int i = 0; i < Math.Abs(power); i++)
        poweredNumber *= number;

    return poweredNumber;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите  степень числа: ");
int pwr = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num} в степени {pwr} равно {Power(num, pwr)}");

int power = PositiveIntegerPower(num, pwr);
string msg = pwr < 0
    ? $"Число {pwr} не является натуральным"
    : $"{num} в степени {pwr} равно {power}";

Console.WriteLine(msg);
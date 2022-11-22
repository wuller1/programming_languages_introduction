// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// string stringNumber = Console.ReadLine();
// var number = Convert.ToInt32(stringNumber);

// if (number < 100)
// {
//     Console.WriteLine($"В числе {number} нет третьей цифры");
// }
// else
// {
//     Console.WriteLine($"Третья цифра числа {number} - {stringNumber[2]}");
// }

Console.Write("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());
int tempNumber = number;
int thirdDigit = 0;

if (number < 100)
{
    Console.WriteLine($"В числе {number} нет третьей цифры");
}
else
{
    while (tempNumber > 99)
    {
        if (tempNumber < 1000)
        {
            thirdDigit = tempNumber % 10;
        }
        tempNumber /= 10;
    }

    Console.WriteLine($"Третья цифра числа {number} - {thirdDigit}");
}


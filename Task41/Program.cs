// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int GreaterThanZero(int[] arr)
{
    int count = 0;
    foreach (var num in arr)
    {
        if (num > 0) count++;
    }
    return count;
}

int[] UserInputToArray()
{
    Console.Write("Введите числа через пробел: ");
    string[] numbersStringArray = Console.ReadLine().Split(" ");
    int[] numbersIntArray = new int[numbersStringArray.Length];

    for (var i = 0; i < numbersIntArray.Length; i++)
    {
        numbersIntArray[i] = int.Parse(numbersStringArray[i]);
    }
    return numbersIntArray;
}

int[] array = UserInputToArray();
Console.WriteLine($"Чисел больше 0: {GreaterThanZero(array)}");
bool isNumber = false;
int number = 0;

while (!isNumber)
{
    Console.Write("Введите число: ");
    isNumber = Int32.TryParse(Console.ReadLine(), out number);
}

bool IsPalindrome(int num)
{
    int reverseNumber = 0;
    int numberTemp = num;

    while (numberTemp != 0)
    {
        reverseNumber = reverseNumber * 10 + numberTemp % 10;
        numberTemp /= 10;
    }

    return num == reverseNumber;
}

string message = IsPalindrome(number) ? $"Число {number} является палиндромом" : $"Число {number} не является палиндромом";
Console.WriteLine(message);
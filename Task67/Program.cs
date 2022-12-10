int SumOfDigits(int number, int sum = 0)
{
    if (number != 0)
    {
        return number % 10 + SumOfDigits(number / 10, sum);
    }
    return 0;
}

Console.WriteLine(SumOfDigits(1534));
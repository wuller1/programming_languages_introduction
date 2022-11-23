Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int numberOfDigits(int number)
{
    if (number == 0)
    {
        return 1;
    }

    int digits = 0;

    while (number != 0)
    {
        digits += 1;
        number /= 10;
    }
    return digits;
}

Console.WriteLine($"Number of digits in number {num} is: {numberOfDigits(num)}");
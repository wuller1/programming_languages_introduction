double Power(double number, int power)
{
    if (power == 0) return 1;
    return power > 0 ? Power(number, --power) * number : Power(number, ++power) / number;
}

Console.WriteLine(Power(3, -5));
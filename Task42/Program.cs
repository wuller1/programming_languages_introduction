string ToBinary(int num)
{
    string binary = string.Empty;
    while (num != 0)
    {
        binary = $"{num % 2}{binary}";
        num /= 2;
    }
    return binary;
}

Console.WriteLine(ToBinary(2));
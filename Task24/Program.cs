Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int sumFromOneToN(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine($"Сумма чисел от 1 до {num} = {sumFromOneToN(num)}");
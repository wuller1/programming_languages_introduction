Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

long Factorial(int number, long factorial = 1)
{
    if (number == 1)
    {
        return factorial;
    }
    factorial *= number;
    number -= 1;
    return Factorial(number, factorial);
}

Console.WriteLine($" {num} is: {Factorial(num)}");
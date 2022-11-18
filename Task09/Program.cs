var number = new Random().Next(10, 100);
int maxNumber = int.MinValue;
int firstNumber = number / 10;
int secondNumber = number % 10;
if (firstNumber >= secondNumber)
{
    maxNumber = firstNumber;
}
else
{
    maxNumber = secondNumber;
}
Console.WriteLine($"Случайное число: {number}, наибольшая цифра: {maxNumber}");
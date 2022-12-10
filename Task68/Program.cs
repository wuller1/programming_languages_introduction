// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AckermannFunction(m - 1, 1);
    else if (m > 0 && n > 0)
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return -1;
}

Console.Write("Введите число m: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({num1}, {num2}) = {AckermannFunction(num1, num2)}");
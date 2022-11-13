Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number % ((number / 10) * 10));

Console.Write("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());
string answer = number % 2 == 0 ? "является" : "не является";
Console.WriteLine($"Число {number} {answer} четным");
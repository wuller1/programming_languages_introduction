Console.WriteLine("Введите четверть: ");
int quarterNumber = Convert.ToInt32(Console.ReadLine());


string QuarterValues(int quarter)
{
    if (quarter == 1) return "x > 0, y > 0";
    if (quarter == 2) return "x < 0, y > 0";
    if (quarter == 3) return "x < 0, y < 0";
    if (quarter == 4) return "x > 0, y < 0";
    return "Введено недопустимое значение";
}

string result = QuarterValues(quarterNumber);

Console.WriteLine(result);
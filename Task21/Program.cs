double ThreeDimensionalLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round((Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2))),
            2,
            MidpointRounding.ToZero);
}

bool isNumber = true;

Console.Write("Введите x1: ");
if (!Int32.TryParse(Console.ReadLine(), out int xc1)) isNumber = false;

Console.Write("Введите y1: ");
if (!Int32.TryParse(Console.ReadLine(), out int yc1)) isNumber = false;

Console.Write("Введите z1: ");
if (!Int32.TryParse(Console.ReadLine(), out int zc1)) isNumber = false;

Console.Write("Введите x2: ");
if (!Int32.TryParse(Console.ReadLine(), out int xc2)) isNumber = false;

Console.Write("Введите y2: ");
if (!Int32.TryParse(Console.ReadLine(), out int yc2)) isNumber = false;

Console.Write("Введите z2: ");
if (!Int32.TryParse(Console.ReadLine(), out int zc2)) isNumber = false;

double length = ThreeDimensionalLength(xc1, yc1, zc1, xc2, yc2, zc2);

string message = isNumber ? $"Для заданных координат А({xc1}, {yc1}, {zc1}); B({xc2}, {yc2}, {zc2}) расстояние между точек равно: {length}" : "Введены некорректные значения";

Console.WriteLine(message);
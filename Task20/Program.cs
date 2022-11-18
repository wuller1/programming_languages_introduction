Console.Write("Введите х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double Calculate2DimensionalDistance(double x1, double y1, double x2, double y2)
{
    return Math.Round((Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))), 2, MidpointRounding.ToZero);
}

double distance = Calculate2DimensionalDistance(x1, y1, x2, y2);

Console.WriteLine($"Расстояние между точками А({x1}, {y1}) и В({x2}, {y2}) равно: {distance}");
double[] GetCoefficients()
{
    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    return new double[] { k1, b1, k2, b2 };

}

double[] LinesIntersectionPoint(double[] coefficients)
{
    double k1 = coefficients[0];
    double b1 = coefficients[1];
    double k2 = coefficients[2];
    double b2 = coefficients[3];

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;

    return new double[] { x, y };
}

double[] linesIntersectionPoint = LinesIntersectionPoint(GetCoefficients());
Console.WriteLine($"Прямые пересекаются в точке с координатами: ({linesIntersectionPoint[0]}; {linesIntersectionPoint[1]})");
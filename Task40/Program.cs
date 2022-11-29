Console.Write("Введите длину первой стороны: ");
int length1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй стороны: ");
int length2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третьей стороны: ");
int length3 = Convert.ToInt32(Console.ReadLine());

bool IsTriangle(int len1, int len2, int len3)
{
    if (len1 >= (len2 + len3)) return false;
    if (len2 >= (len1 + len3)) return false;
    if (len3 >= (len1 + len2)) return false;
    return true;
}
string msg = IsTriangle(length1, length2, length3) ? "Может существовать" : "Не может существовать";
Console.WriteLine($"{msg}");
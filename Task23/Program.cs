int number = -1;
bool isNumber = false;

while (!isNumber || number < 0)
{
    Console.Write("Введите число: ");
    isNumber = Int32.TryParse(Console.ReadLine(), out number);
}

string CubeTable(int num)
{
    string table = "";
    for (int i = 1; i <= num; i++)
    {
        table += $"{i}\t{i * i * i}\n";
    }
    return table;
}

Console.WriteLine(CubeTable(number));
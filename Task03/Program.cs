Console.Write("Введите число дня недели (от 1 до 7): ");
int dayOfWeekNumber = Convert.ToInt32(Console.ReadLine());
string[] daysOfWeek = new string[] {
    "Понедельник",
    "Вторник",
    "Среда",
    "Четверг",
    "Пятница",
    "Суббота",
    "Воскресенье",
};

if (dayOfWeekNumber >= 1 && dayOfWeekNumber <= 7)
{
    Console.WriteLine(daysOfWeek[dayOfWeekNumber - 1]);
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}

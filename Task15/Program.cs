// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int number;
do
{
    Console.Write("Введите день недели: ");
    number = Convert.ToInt32(Console.ReadLine());
}
while (number < 1 || number > 7);

var answer = (number == 6 || number == 7) ? "Да" : "Нет";

Console.WriteLine(answer);
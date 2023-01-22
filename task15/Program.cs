// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32 (Console.ReadLine());

if (day >= 1 && day <= 7)
{
    if (day == 6 || day == 7)
    {
        System.Console.WriteLine("Это выходной день");
    }
    else
    {
        System.Console.WriteLine("Это не выходной день, надо на работу )= ");
    }
}
else
{
    System.Console.WriteLine("Такого дня нет");
}
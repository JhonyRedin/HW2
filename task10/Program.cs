﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32 (Console.ReadLine());

if ( number > 99 && number < 1000)
{
    number = number/10;
    number = number%10;
    System.Console.WriteLine($"Вторая цифра: {number}");
}
else 
{
    System.Console.WriteLine("Введено не верное число");
}
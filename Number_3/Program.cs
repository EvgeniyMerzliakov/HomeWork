﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());
int remains = 1;

remains = x % 2;
if (remains < 1 && remains > -1)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}
﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int z = Convert.ToInt32(Console.ReadLine());
int max = x;

if (max < y) 
{
    max = y;
}
    else 
    {
        max = x;
    }

if (max < z) 
{
    max = z;
}
    else 
    {
        max = max;
    }

Console.Write("max = ");
Console.WriteLine(max);
﻿// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("введите число: ");
int numbereven = Convert.ToInt32(Console.ReadLine());

if (numbereven % 2 == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}

Console.WriteLine("задача выполнена");
﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if ( n % 2 == 0 )
    Console.WriteLine("число чётное");
else
    Console.WriteLine("число не чётное");
﻿//Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.   3 -> 1, 8, 27   5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = 0;
for ( int i = 1; i <= n; i++ )
{
    n1 = i*i*i;
    Console.WriteLine($"{n1}");
}
﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("напишите цифру дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1 && n > 7)
{
    Console.WriteLine("Это не день недели! Введите цифру дня недели");
}
else if (n == 6 && n == 7 ) 
{
    Console.WriteLine("это выходной день");
}

﻿//// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 


Console.WriteLine("Введите числa: ");
string[] n = Console.ReadLine().Split(" ");
int count = 0;
foreach (string i in n)
{
   if (int.Parse(i) > 0)
       count++;
}
Console.WriteLine(count);

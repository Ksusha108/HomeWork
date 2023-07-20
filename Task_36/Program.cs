﻿// 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных 
// позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] arr = new int[6];
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 10);
}
Console.WriteLine($"[{string.Join(", ",arr)}]");

for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 == 1)
    {
        sum = sum + arr[i];
      
    }    
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
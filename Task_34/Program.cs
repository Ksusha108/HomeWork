﻿// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] arr = new int[6];
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);
}
Console.WriteLine($"[{string.Join(", ",arr)}]");


for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        sum = sum + 1;
      
    }    
}
Console.WriteLine($"колличество чётных чисел в массивв = {sum}");
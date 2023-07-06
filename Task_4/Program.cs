// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7  max = 7

Console.WriteLine("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

 Console.WriteLine($"максимальное число = {max}");   
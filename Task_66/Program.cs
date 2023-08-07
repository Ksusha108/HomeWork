// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке
//   от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int rec(int m, int n)
{
    if (n == m)
        return m;
    return rec(m, n - 1) + n;    
}

Console.WriteLine("Введите значение n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));
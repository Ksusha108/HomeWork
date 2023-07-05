// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.
Console.WriteLine("Введите 1-е число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int m = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if (n > m )
    {
        max = n;
        min = m;
    }
else
    {
        max = m;
        min = n;
    }

Console.WriteLine($"Болшее число = {max}, меньшее число = {min}");

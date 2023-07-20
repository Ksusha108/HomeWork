//19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет

Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 10000 || n > 99999)
{
    Console.WriteLine("Это не пятизначное число! Введите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
   
}


if (n > 9999 && n < 100000)
{
    int n1 = n / 10000;
    int n2 = n / 1000 % 10;
    int n3 = n / 10 % 10;
    int n4 = n % 10;

    if (n1 == n4 && n2 == n3)
    {
        Console.WriteLine("Это палиндром!");
    }
    else
        Console.WriteLine("Это не палиндром");
}


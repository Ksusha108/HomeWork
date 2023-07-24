// 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным
//  элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[4];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble() * 100, 2);
  
}

double MaxArray(double[] array)
{
    double maxArray = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxArray < array[i])
            maxArray = array[i];
    }
    return maxArray;
}

double MinArray(double[] array)
{
    double minArray = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minArray > array[i])
            minArray = array[i];
    }
    return minArray;
}


Console.WriteLine($"Наальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Разница между max и min эл-ом массива: {MaxArray(array) - MinArray(array)}");


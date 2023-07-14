// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.


int enterValue (string prompt)
{
    Console.Write($"Введите координату точки {prompt}");
    int value = Convert.ToInt32(Console.ReadLine());

    return value;
}

int xa = enterValue("a по оси x: ");
int ya = enterValue("a по оси y: ");
int za = enterValue("a по оси z: ");
Console.WriteLine();
int xb = enterValue("b по оси x: ");
int yb = enterValue("b по оси y: ");
int zb = enterValue("b по оси z: ");
Console.WriteLine();

double distance = Math.Sqrt(Math.Pow((xa - xb),2) + Math.Pow((ya - yb),2) +  Math.Pow((za - zb),2) );
Console.Write($"Расстояние между точками равно:{Math.Round(distance,2)}");


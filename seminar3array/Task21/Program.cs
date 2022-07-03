/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

double GetDistanceAB(int[] a, int[] b)
{
    return Math.Sqrt((b[0]-a[0])*(b[0]-a[0])+(b[1]-a[1])*(b[1]-a[1]));
}

int[] a = new int[2];
int[] b = new int[2];

Console.Write("Введите 1 ую координату точки А: ");
a[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 ую координату точки А: ");
a[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 1 ую координату точки B: ");
b[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 ую координату точки B: ");
b[1] = Convert.ToInt32(Console.ReadLine());

double distance = GetDistanceAB(a, b);
Console.WriteLine($"Расстояние между точками A({a[0]},{a[1]}) и B({b[0]},{b[1]}) {distance}");
/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double GetDistanceAB(int[] a, int[] b)
{
    return Math.Sqrt((b[0] - a[0]) * (b[0] - a[0]) + (b[1] - a[1]) * (b[1] - a[1]) + (b[2] - a[2]) * (b[2] - a[2]));
}

int[] a = new int[3];
int[] b = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.Write($"Введите {i} ую координату точки А: ");
    a[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 3; i++)
{
    Console.Write($"Введите {i} ую координату точки B: ");
    b[i] = Convert.ToInt32(Console.ReadLine());
}

double distance = GetDistanceAB(a, b);
Console.WriteLine($"Расстояние между точками A({a[0]},{a[1]},{a[2]}) и B({b[0]},{b[1]},{b[2]}) {distance}");
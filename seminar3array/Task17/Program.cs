/*
17. Напишите программу, которая принимает на вход координаты точки (X и Y),
причем X не равно 0 и Y не равно 0 и выдает номер четверти плоскости, в которой находится эта точка.
*/
int GetNumberOfQuarter(double X, double Y)
{
    int result = 0;
    if (X > 0 && Y > 0)
    {
        result = 1;
    }
    else if (X < 0 && Y > 0)
    {
        result = 2;
    }
    else if (X < 0 && Y < 0)
    {
        result = 3;
    }
    else if (X > 0 && Y < 0)
    {
        result = 4;
    }
    return result;
}

Console.WriteLine("Введите координату X:");
double userX = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Y:");
double userY = Convert.ToDouble(Console.ReadLine());

int quarter = GetNumberOfQuarter(userX, userY);
if (quarter > 0)
{
    Console.WriteLine($"Точка с координатами [{userX}:{userY}] лежит в {quarter} четверти");
}
else
{
    Console.WriteLine($"Точка с координатами [{userX}:{userY}] находиться на оси координат");
}

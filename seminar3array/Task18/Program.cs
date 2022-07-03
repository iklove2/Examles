//Задача 18: Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

void GetNumberOfXY(int quater)
{
    //int result = 0;
    if (quater == 1)
    {
        Console.WriteLine($"Диапазон возможных координат X > 0 Y < 0");
    }
    else if (quater == 2)
    {
        Console.WriteLine($"Диапазон возможных координат X < 0 Y > 0");
    }
    else if (quater == 3)
    {
        Console.WriteLine($"Диапазон возможных координат X < 0 Y < 0");
    }
    else if (quater == 4)
    {
        Console.WriteLine($"Диапазон возможных координат X > 0 Y < 0");
    }
    else 
    {
        Console.WriteLine("Нет такой четверти");
    }
}

Console.WriteLine("Введите номер четверти: ");
int quater = Convert.ToInt32(Console.ReadLine());

GetNumberOfXY(quater);

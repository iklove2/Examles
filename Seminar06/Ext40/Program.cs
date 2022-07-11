/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

bool Check(int[] array)
{
    int lenght = array.Length;
    int numberofcheck = 0;
    bool result = false;
    for (var i = 0; i < lenght; i++)
    {
        if (array[i] < array[(i + 1) % lenght] + array[(i + 2) % lenght])
        {
            numberofcheck++;
        }
    }
    result = (numberofcheck == lenght);
    return result;
}

int[] ArrayInput()
{
    int[] array = new int[3];
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} сторону: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] arrayToShow)
{
    Console.Write("[");
    for (var i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i < arrayToShow.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int[] arrayOfSide = new int[3];
arrayOfSide = ArrayInput();
bool flag = Check(arrayOfSide);
if (flag)
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}


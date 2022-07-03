/*
Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void TableOfCubes(int N)
{
    Console.Write($"Для числа {N} -> ");
    for (int i = 1; i <= N; i++)
    {
        if (i < N)
        {
            Console.Write($"{i * i * i}, ");
        }
        else
        {
            Console.Write($"{i * i * i}.");
        }

    }
}


Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
TableOfCubes(N);
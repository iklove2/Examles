/*
Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

void TableOfSquares(int N)
{
    Console.Write($"Для числа {N} -> ");
    for (int i = 1; i <= N; i++)
    {
        if (i < N)
        {
            Console.Write($" {i * i}, ");
        }
        else
        {
            Console.Write($" {i * i}.");
        }

    }
}


Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
TableOfSquares(N);
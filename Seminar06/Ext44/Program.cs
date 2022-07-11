/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/


int[] DesignFib(int Nfib)
{
    int[] Fibb = new int[Nfib];
    if (Nfib > 2)
    {
        Fibb[0] = 0;
        Fibb[1] = 1;

        for (var i = 2; i < Nfib; i++)
        {
            Fibb[i] = Fibb[i - 2] + Fibb[i - 1];
        }
    }
    else if (Nfib == 1)
    {
        Fibb[0] = 0;
    }
    else if (Nfib == 2)
    {
        Fibb[0] = 0;
        Fibb[1] = 1;
    }
    return Fibb;
}

void PrintFib(int[] Nfib)
{
    int lenght = Nfib.Length;
    Console.Write($"Если N = {lenght} -> ");
    for (var i = 0; i < lenght; i++)
    {
        Console.Write($"{Nfib[i]} ");
    }
}

Console.Write($"Введите N: ");
int Nfib = Convert.ToInt32(Console.ReadLine());
int[] Fibbonachi = new int[Nfib];
Fibbonachi = DesignFib(Nfib);
PrintFib(Fibbonachi);

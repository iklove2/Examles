/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

int Akkerman(int M, int N)
{
    // Базовый случай
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return Akkerman(M - 1, Akkerman(M, N - 1));
    }

}

Console.ResetColor();
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M < 0 || N < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("не корректный ввод");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"m = {M}, n = {N} -> Аккерман({M},{N}) = {Akkerman(M, N)}");
    Console.ResetColor();
}
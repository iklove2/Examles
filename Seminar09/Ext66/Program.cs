/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int NaturalRec(int N, int count = 1)
{
    if (count <= N)
    {
        return NaturalRec(N, count + 1) + count;
    }
    else
    {
        return 0;
    }
}

Console.ResetColor();
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M > N)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"M = {M} больше N = {N}, не корректный ввод");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"M = {M}; N = {N} -> {NaturalRec(N, M)}");
    Console.ResetColor();
}
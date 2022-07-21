/*
Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

void NaturalRec(int N, int count = 1)
{
    if (count == N)
    {
        Console.Write($"{count}\"");
    }
    else
    {
        Console.Write($"{count}, ");
        NaturalRec(N, count + 1);
    }
}

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M > N)
{
    Console.Write($"M = {M} больше N = {N}, не корректный ввод");
}
Console.Write($"M = {M}; N = {N} -> \"");
NaturalRec(N, M);
/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
*/

int[,] GenerateArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

int[,] CopyArray(int[,] Array)
{
    int[,] result = new int[Array.GetLength(0), Array.GetLength(1)];

    for (int i = 0; i < Array.GetLength(0); i = i++)
    {
        for (int j = 0; j < Array.GetLength(1); j = j++)
        {
            result[i, j] = Array[i, j];
        }
    }
    return result;
}

int[,] ChangeArray(int[,] Array)
{
    int[,] result = CopyArray(Array);
    for (int i = 0; i < Array.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < Array.GetLength(1); j = j + 2)
        {
            result[i, j] = Array[i, j] * Array[i, j];
        }
    }
    return result;
}

void printGreen(int number)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{number}\t");
    Console.ResetColor();
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (var i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printGreen(i);
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printGreen(i);
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j]);
            if (j < arrayToPrint.GetLength(1) - 1)
            {
                Console.Write("\t");
            }
        }
        Console.WriteLine();
    }
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] SourceArray = GenerateArray(m, n);
int[,] NewArray = ChangeArray(SourceArray);
print2DArray(SourceArray);
//print2DArray(NewArray);

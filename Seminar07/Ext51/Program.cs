/*
Задача 51: Задайте двумерный массив. Найдите сумму главой диагонали массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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

int MinLength(int[,] array)
{
    int length = array.GetLength(0);
    if (length > array.GetLength(1))
    {
        length = array.GetLength(1);
    }
    return length;
}


int SumMainDiagnal(int[,] array)
{
    int sum = 0;
    int length = MinLength(array);
    for (var i = 0; i < length; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

int[] GetDiagonal(int[,] array)
{
    int length = MinLength(array);
    int[] result = new int[length];
    for (var i = 0; i < length; i++)
    {
        result[i] = array[i, i];
    }
    return result;
}

void PrintDiagonal(int[] array, int sum)
{
    for (var i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]} + ");
        }
        else
        {
            Console.Write($"{array[i]} = ");
        }

    }
    Console.Write($"{sum}");
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = GenerateArray(m, n);
int sum = SumMainDiagnal(array);
int[] diagonal = GetDiagonal(array);
print2DArray(array);
Console.WriteLine();
PrintDiagonal(diagonal, sum);

Console.WriteLine();

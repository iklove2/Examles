/*
Задача 56: 
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GenerateArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return result;
}
void printRed(int number)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($" {number}");
    Console.ResetColor();
}
void printBlue(int number)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write($"{number}");
    Console.ResetColor();
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
        Console.Write(" ");
        printGreen(i);
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printGreen(i);
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            if (arrayToPrint[i, j] >= 0)
            {
                printRed(arrayToPrint[i, j]);
            }
            else
            {
                printBlue(arrayToPrint[i, j]);
            }

            if (j < arrayToPrint.GetLength(1) - 1)
            {
                Console.Write("\t");
            }
        }
        Console.WriteLine();
    }
}
int getSumOfRow(int[,] array,int row)
{
    int sumOfrow = 0;
    for (var i = 0; i < array.GetLength(1); i ++)
    {
        sumOfrow += array[row,i];
    }
    if(sumOfrow < 0)
    {
Console.WriteLine($"{row}\t{sumOfrow}");
    }
    else
    {
Console.WriteLine($"{row}\t {sumOfrow}");
    }
    
    return sumOfrow;
}
int FindingMinSumRow(int[,] arrayToSort)
{
    int rows = arrayToSort.GetLength(0);
    int cols = arrayToSort.GetLength(1);
    int findRow = 0;
    int sumOfrow = 0;
    int sumOfrowPrev = getSumOfRow(arrayToSort, 0);
    for(int rowCurrent = 1; rowCurrent < rows; rowCurrent++)
    {
        sumOfrow = getSumOfRow(arrayToSort, rowCurrent);
        if(sumOfrow < sumOfrowPrev)
        {
            findRow = rowCurrent;
            sumOfrowPrev = sumOfrow;
        }
    }
    return findRow;
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = GenerateArray(m, n, 20);

print2DArray(array);
Console.WriteLine("Суммы по столбцам для удобства проверки");
int minSumRow = FindingMinSumRow(array);

Console.WriteLine($"Наименьшая сумма в строке:  {minSumRow}");
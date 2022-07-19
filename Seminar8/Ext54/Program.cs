/*
**Задача 54:** Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
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
int[,] SelectionSort(int[,] arrayToSort)
{
    int rows = arrayToSort.GetLength(0);
    int cols = arrayToSort.GetLength(1);
    for(int rowCurrent = 0; rowCurrent < rows; rowCurrent++)
    {
    for (int i = 0; i < cols - 1; i++)
    {
        int maxPosition = i;

        for(int j = i + 1; j < cols; j++)
        {
            if (arrayToSort[rowCurrent,j] < arrayToSort[rowCurrent,maxPosition])
            {
                maxPosition = j;
            }
        }
        int temporary = arrayToSort[rowCurrent,i];
        arrayToSort[rowCurrent,i] = arrayToSort[rowCurrent,maxPosition];
        arrayToSort[rowCurrent,maxPosition] = temporary;
    }
    }
    return arrayToSort;
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = GenerateArray(m, n, 20);
print2DArray(array);
array = SelectionSort(array);
print2DArray(array);
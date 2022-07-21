/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/
const int numberOfUniqNumbers = 90;
int GetUniqNumber(int[] number, int start = 10, int finish = 100, int deviation = 10)
{
    int result = 0;
    bool isUniq = false;
    while (!isUniq)
    {
        result = new Random().Next(start, finish);
        System.Console.WriteLine($" {result}");
        if (number[result - deviation] == 0)
        {
            isUniq = true;
            number[result - deviation] = 1;
        }
        else
        {
System.Console.WriteLine($"Не уникально {result}");
        }
        if (number.Sum() == finish - start)
        {
            break;
        }
    }
    return result;
}

int[,] Generate2DUniqArray(int rowCount, int colCount)
{
    int[,] result = new int[rowCount, colCount];
    int[] uniqNumbers = new int[numberOfUniqNumbers];
    for (var i = 0; i < rowCount; i++)
    {
        for (var j = 0; j < rowCount; j++)
        {
            result[i, j] = GetUniqNumber(uniqNumbers);
        }
    }
    return result;
}

void printColor(string message, ConsoleColor color = ConsoleColor.Green)
{
    Console.ForegroundColor = color;
    Console.Write($"{message}\t");
    Console.ResetColor();
}
void showHead(string nameOfArray)
{
    if (!string.IsNullOrEmpty(nameOfArray))
    {
        Console.WriteLine();
        printColor($" {nameOfArray} ", ConsoleColor.DarkCyan);
        Console.WriteLine();
    }
}

void print2DArray(int[,] arrayToPrint)
{
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            printColor($"{arrayToPrint[i, j]}", ConsoleColor.DarkMagenta);
        }
        Console.WriteLine();
    }
}

int[,] array = Generate2DUniqArray(10,7);
print2DArray(array);
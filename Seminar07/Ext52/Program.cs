/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] AvgCalc(int[,] arrayToAvgCalc)
{
    int length = arrayToAvgCalc.GetLength(1);
    int rows = arrayToAvgCalc.GetLength(0);
    double[] result = new double[length];
    double avgtemp = 0;
    for (var j = 0; j < length; j++)
    {
        for (var i = 0; i < rows; i++)
        {
            avgtemp += arrayToAvgCalc[i, j];
        }
        result[j] = avgtemp / rows;
    }
    return result;
}

void printDoubleRed(double number)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($" {number}");
    Console.ResetColor();
}

void printDoubleBlue(double number)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write($"{number}");
    Console.ResetColor();
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
void printAvgArray(double[] AavgArray, int MidPointRound)
{
    Console.WriteLine("Среднее арифметическое столбцов");
    Console.Write(" \t");
    for (var i = 0; i < AavgArray.Length; i++)
    {
        Console.Write(" ");
        printGreen(i);
    }
    Console.WriteLine();
    Console.Write(" \t");
    for (int i = 0; i < AavgArray.Length; i++)
    {
        if (AavgArray[i] >= 0)
        {
            printDoubleRed(Math.Round(AavgArray[i], MidPointRound));
        }
        else
        {
            printDoubleBlue(Math.Round(AavgArray[i], MidPointRound));
        }
        if (i < AavgArray.Length - 1)
        {
            Console.Write("\t");
        }
    }
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точность округления: ");
int MidPointRound = Convert.ToInt32(Console.ReadLine());

int[,] array = GenerateArray(m, n, 20);
print2DArray(array);
double[] avgarray = AvgCalc(array);
printAvgArray(avgarray, MidPointRound);



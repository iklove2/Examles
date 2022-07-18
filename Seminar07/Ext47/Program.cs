/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] generateArray(int rowNumber, int colNumber, int deviation, int MidPointRound)
{
    double[,] result = new double[rowNumber, colNumber];
    double randomelement = 0;
    double division = 1;
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            randomelement = new Random().Next(-deviation * 1000, deviation * 1000 + 1);
            division = new Random().Next(deviation, deviation * 100 + 1);
            Console.WriteLine(Math.Round(randomelement / division, MidPointRound));
            result[i, j] = Math.Round(randomelement / division, MidPointRound);
            Console.WriteLine(result[i, j]);
        }
    }
    return result;
}

void printRed(double number)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($" {number}");
    Console.ResetColor();
}

void printBlue(double number)
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

void print2DArray(double[,] arrayToPrint)
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
            if (arrayToPrint[i, j] > 0)
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

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точность округления: ");
int MidPointRound = Convert.ToInt32(Console.ReadLine());
double[,] array = generateArray(m, n, 10, MidPointRound);//m n, далее разброс чисел, кол-во знаков после запятой
print2DArray(array);
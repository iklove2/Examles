/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
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
        printColor($"-------------------------- {nameOfArray} --------------------------", ConsoleColor.DarkCyan);
        Console.WriteLine();
    }
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
int[,] MultMatrixAB(int[,] matrixA, int[,] matrixB)
{
    int mC = matrixA.GetLength(0);
    int kC = matrixB.GetLength(1);
    int nB = matrixB.GetLength(0);
    int[,] matrixC = new int[mC, kC];
    for (int z = 0; z < mC; z++)
    {
        for (int j = 0; j < kC; j++)
        {
            for (int k = 0; k < nB; k++)
            {
                matrixC[z, j] += matrixA[z, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

Console.Write("Введите m матрицы А: ");
int mA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n матрицы A: ");
int nA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите m матрицы B: ");
int nB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n матрицы B: ");
int kB = Convert.ToInt32(Console.ReadLine());

if (nA == nB)
{
    int[,] matrixA = GenerateArray(mA, nA, 10);
    showHead(" Матрица  А");
    print2DArray(matrixA);

    int[,] matrixB = GenerateArray(nB, kB, 10);
    showHead(" Матрица  B");
    print2DArray(matrixB);

    int[,] matrixC = MultMatrixAB(matrixA, matrixB);
    showHead("Матрица АxB");
    print2DArray(matrixC);
}
else
{
    Console.Write("Произведение не найти ");
}

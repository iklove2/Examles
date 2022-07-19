/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

int[,] GenerateSpiralArray(int Narray)
{
    int[,] spiralArray = new int[Narray, Narray];
    int count = 1;
    int row = 0;
    int col = 0;
    while (count <= Narray * Narray)
    {
        spiralArray[row, col] = count;
        if (row <= col + 1 && row + col < Narray - 1)
        {
            col++;
        }
        else if (row < col && row + col >= Narray - 1)
        {
            row++;
        }
        else if (row >= col && row + col > Narray - 1)
        {
            col--;
        }
        else
        {
            row--;
        }
        count++;
    }
    return spiralArray;
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

Console.Clear();
Console.Write("Введите размер матрицы N: ");
int Narray = Convert.ToInt32(Console.ReadLine());
int[,] spiralArray = GenerateSpiralArray(Narray);
showHead($" Спиралевидная матрица со стороной {Narray} ");
print2DArray(spiralArray);
Console.WriteLine();
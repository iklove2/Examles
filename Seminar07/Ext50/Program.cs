/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

double GetElementArray(int[,] array, int PositionNumber)
{
    double result = 0.1;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int rowPosition = PositionNumber / rows;
    //int colPosition = 0;
    int count = 0;
    /*    if (cols < rows)
        {
            colPosition = PositionNumber % (cols ) ;
        }
        else if (cols > rows)
        {
            colPosition = PositionNumber % (cols );
        }
        else if (cols == rows)
        {
            colPosition = PositionNumber % (cols);
        }*/
    if (((rows - 1) + (rows - 1) * (cols - 1) + (cols - 1)) < PositionNumber)
    {
        return result;
    }
    else
    {
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (count == PositionNumber)
                {
                    result = Convert.ToDouble(array[i, j]);
                    break;
                }
                count++;
            }
        }
        // Console.WriteLine($"{rows}  {cols}  : Строка {rowPosition} Столбец {colPosition} {((rows - 1) + (rows - 1) * (cols - 1) + (cols - 1))}");
        // result = " dfgdf";
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

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию элемента: ");
int PositionNumber = Convert.ToInt32(Console.ReadLine());

int[,] array = GenerateArray(m, n, 20);
print2DArray(array);
double getElement = GetElementArray(array, PositionNumber);
if (getElement == 0.1)
{
    Console.WriteLine("Нет такого элемента");
}
else
{
    Console.WriteLine(getElement);
}





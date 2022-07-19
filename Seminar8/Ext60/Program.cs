/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/

int[,,] GenerateUnicumArray(int Narray, int deviation)
{
    Random rnd = new Random();
    int buffer = 0;
    int[,,] UnicumArray = new int[Narray, Narray, Narray];
    for (var z = 0; z < Narray; z++)
    {
        for (var i = 0; i < Narray; i++)
        {
            for (var j = 0; j < Narray; j++)
            {
                while (true)
                {
                    buffer = rnd.Next(-deviation, deviation + 1);
                    if (buffer < -9 || buffer > 9)
                    {
                        UnicumArray[z, i, j] = buffer;
                        for (var zch = 0; zch < Narray; zch++)
                        {
                            for (var ich = 0; ich < Narray; ich++)
                            {
                                for (var jch = 0; jch < Narray; jch++)
                                {
                                    if (UnicumArray[z, i, j] == UnicumArray[zch, ich, jch])
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        break;
                    }
                }
            }
        }
    }
    return UnicumArray;
}

void printColor(string message, ConsoleColor color = ConsoleColor.Green)
{
    Console.ForegroundColor = color;
    Console.Write($"{message}\t");
    Console.ResetColor();
}

void PrintArray(int[,,] UnicumArray)
{
    int Narray = UnicumArray.GetLength(0);
    for (var z = 0; z < Narray; z++)
    {
        for (var i = 0; i < Narray; i++)
        {
            for (var j = 0; j < Narray; j++)
            {
                if (UnicumArray[z, i, j] < 0)
                {
                    printColor($"{UnicumArray[z, i, j]}({z},{i},{j})\t", ConsoleColor.Blue);
                }
                else
                {
                    printColor($" {UnicumArray[z, i, j]}({z},{i},{j})\t", ConsoleColor.Red);
                }
            }
            Console.WriteLine();
        }
    }
}


Console.Write("Введите размерность массива N:");
int Narray = Convert.ToInt32(Console.ReadLine());
int[,,] UnicumArray = GenerateUnicumArray(Narray, 99);
PrintArray(UnicumArray);

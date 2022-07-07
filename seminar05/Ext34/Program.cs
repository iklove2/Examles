/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] generateArray(int length, int startBorder, int endBorder)
{
    int[] resultArray = new int[length];
    for (var i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startBorder, endBorder + 1);
    }
    return resultArray;
}

int evenCount(int[] arrayNumber)
{
    int count = 0;
    for (var i = 0; i < arrayNumber.Length; i++)
    {
        if (arrayNumber[i] % 2 == 0)
        {
           count++; 
        }
    }
    return count;
}

void ShowArray(int[] arrayToShow)
{
    Console.Write("[");
    for (var i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i < arrayToShow.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

Console.Write("Введите длину масcива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] arrayNumber = new int[length];

arrayNumber = generateArray(length, 100, 999);
ShowArray(arrayNumber);

int evencount = evenCount(arrayNumber);
Console.WriteLine($" -> {evencount}");
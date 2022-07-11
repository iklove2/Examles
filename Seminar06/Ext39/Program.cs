/*
Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int[] generateArray(int length, int deviation)
{
    int[] resultArray = new int[length];
    for (var i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(-deviation, deviation + 1);
    }
    return resultArray;
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
    Console.WriteLine("]");
}

int[] reverseArray(int[] arraytoReverse)
{
    int length = arraytoReverse.Length;
    int[] reversedArray = new int[length];
    for (var i = 0; i < length; i++)
    {
        reversedArray[i] = arraytoReverse[length - i - 1];
    }
    return reversedArray;
}



int[] sourceArray = generateArray(10, 20);
int[] reversedArray = reverseArray(sourceArray);

ShowArray(sourceArray);
ShowArray(reversedArray);

//Console.WriteLine($"Сумма положительных = {sumOfPositive}, сумма отрицательных {sumOfNegative} ");

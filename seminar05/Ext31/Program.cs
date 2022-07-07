/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.
*/
int[] generateArray(int length, int startBorder, int endBorder)
{
    int[] resultArray = new int[length];
    for (var i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startBorder,endBorder+1);
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
int getSumOfPositiveOrNegative(int[] array, int deviation = 1)
{
    int sumOfArray = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(array[i] * deviation > 0)
        {
            sumOfArray += array[i];
        }
    }
    return sumOfArray;
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

int[] generatedArray = generateArray(12,-9,9);
ShowArray(generatedArray);
int sumOfPositive = getSumOfPositiveOrNegative(generatedArray,1);
int sumOfNegative = getSumOfPositiveOrNegative(generatedArray,-1);
Console.WriteLine($"Сумма положительных = {sumOfPositive}, сумма отрицательных {sumOfNegative} ");

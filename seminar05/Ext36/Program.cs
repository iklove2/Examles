/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
int getSumOfodd(int[] array)
{
    int sumOfodd = 0;
    for (var i = 1; i < array.Length; i = i + 2)
    {
        sumOfodd += array[i];
    }
    return sumOfodd;
}

Console.Write("Введите длину масcива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] arrayNumber = new int[length];

arrayNumber = generateArray(length, -100, 100);
ShowArray(arrayNumber);

int sumOfodd = getSumOfodd(arrayNumber);
Console.WriteLine($" -> {sumOfodd}");

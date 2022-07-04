/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[7]}]");
}    

int[] GetRandom()
{
    int[] array = new int [8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}

int[] array = new int[8];
array = GetRandom();
PrintArray(array);


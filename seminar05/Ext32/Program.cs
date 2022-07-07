/*
Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
Console.Write("Введите количество элементов массива");
int length = Convert.ToInt32(Console.ReadLine());

int[] Inversarray(int[] array)
{
    
    for(int i=0;i<length; i++)
    {
        array[i] *=-1;
    }
    return array;
}

int[] EnterArray(int length)
{
    int[] array = new int[length];
    for(int i=0;i<length; i++)
    {
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array, int[] invArray)
{
   Console.Write("[");
     for (var i = 0; i < length; i++)
    {
        Console.Write(array[i]);
        if (i < length - 1)
        {
             Console.Write(", ");
        }
    }
     Console.Write("] -> ");
   Console.Write("[");
     for (var i = 0; i < length; i++)
    {
        Console.Write(invArray[i]);
        if (i < length - 1)
        {
             Console.Write(", ");
        }
    }
     Console.WriteLine("]");
}

int[] numberArray = new int[length];
int[] invArray = new int[length];
numberArray =EnterArray(length);
invArray =EnterArray(length);
PrintArray(numberArray, invArray);
void fillArrayNumber(int[] array)
{
    for (var i=0; i < array.Length; i++)
    {
        array[i] = i*i;
    }
}


void printArray(int[] array)
{
    for (var i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }

}

int[] array1 = new int[5];
int[] array2 = new int[5];

fillArrayNumber(array1);
printArray(array1);
printArray(array2);












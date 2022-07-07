/*
Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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

bool IsDigitInArray(int digit, int[] array)
{
    bool isDigit = false;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] == digit)
        {
            isDigit = true;
            break;
        }
    }
    return isDigit;
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





Console.Write("Введите длину масива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
array = generateArray(length, -300, 300);
ShowArray(array);
Console.Write("Введите число для проверки: ");
int digit = Convert.ToInt32(Console.ReadLine());

bool flag = IsDigitInArray(digit, array);
string isDigitStr = (flag) ? "" : "не ";
Console.WriteLine($"Число {isDigitStr} {digit} входит в массив");
ShowArray(array);
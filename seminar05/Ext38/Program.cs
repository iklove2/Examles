/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double[] generateArray(int length, int startBorder, int endBorder)
{
    double[] resultArray = new double[length];
    double randomelement;
    for (var i = 0; i < length; i++)
    {
        randomelement = new Random().Next(startBorder, endBorder + 1);
        resultArray[i] = Convert.ToDouble(randomelement / 100);
    }
    return resultArray;
}

double[] getDiffMinMax(double[] arrayNumber)
{
    double[] maxminDiff = new double[3];//ввел массив для красивого вывода
    maxminDiff[0] = arrayNumber[0];//0 - элемент - минимальное число, 1 - максимальное
    maxminDiff[1] = arrayNumber[0];//2 - разница между максимальным и минимальным значением 
    for (var i = 1; i < arrayNumber.Length; i++)
    {
        if (arrayNumber[i] < maxminDiff[0])//ищем очередной минимальный элемент 
        {
            maxminDiff[0] = arrayNumber[i];
        }
        if (arrayNumber[i] > maxminDiff[1])//ищем очередной максимальный элемент 
        {
            maxminDiff[1] = arrayNumber[i];
        }
    }
    maxminDiff[2] = maxminDiff[1] - maxminDiff[0];//вычисляем разницу и записываем результат
    return maxminDiff;
}

void ShowArray(double[] arrayToShow, double[] maxminDiff)
{
    Console.Write("[");
    for (var i = 0; i < arrayToShow.Length; i++)
    {
        if (arrayToShow[i] == maxminDiff[0])//выделим зеленым цветом минимальное значение
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (arrayToShow[i] == maxminDiff[1])//выделим красным цветом максимальное значение
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.Write(arrayToShow[i]);
        if (i < arrayToShow.Length - 1)
        {
            Console.ResetColor();
            Console.Write(", ");
        }
        Console.ResetColor();
    }
    Console.Write("]");
}

void main()
{
    Console.Clear();
    Console.Write("Введите длину массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    double[] arrayNumber = new double[length];
    arrayNumber = generateArray(length, 1000, 9999);
    double[] maxminDiff = new double[3];//ввел массив для красивого вывода
    maxminDiff = getDiffMinMax(arrayNumber);

    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Красным");
    Console.ResetColor();
    Console.Write(" подсвечен максимальный элемент массива, ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("зеленым ");
    Console.ResetColor();
    Console.WriteLine("- минимальный.");
    Console.WriteLine();

    ShowArray(arrayNumber, maxminDiff);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($" -> {maxminDiff[2]}");
    Console.ResetColor();
    Console.WriteLine();
}

main();
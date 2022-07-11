/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
void ShowArray(int[] arrayOfNumber)
{
    int lenght = arrayOfNumber.Length;
    for (var i = 0; i < lenght - 1; i++)
    {
        if (i < lenght - 2)
        {
            Console.Write($"{arrayOfNumber[i]}, ");
        }
        else
        {
            Console.Write($"{arrayOfNumber[i]}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($" -> {arrayOfNumber[lenght - 1]}");
            Console.ResetColor();
        }
    }
}


int[] CountPositive(int[] Numbers)
{
    int countPositive = 0;
    int lenght = Numbers.Length;
    for (var i = 0; i < lenght - 1; i++)//в последний элемент запишем посчитанное значение положительных чисел
    {
        Console.Write($"Введите {i} число: ");
        Numbers[i] = Convert.ToInt32(Console.ReadLine());
        if (Numbers[i] > 0)
        {
            countPositive++;
        }
    }
    Numbers[lenght - 1] = countPositive;
    return Numbers;
}

void main()
{
    Console.Clear();
    int countNumber = 0;
    Console.Write("Введите количество чисел М: ");
    countNumber = Convert.ToInt32(Console.ReadLine());
    int[] arrayOfNumber = new int[countNumber + 1]; //дополнительный элемент массива для записи значения положительных чисел
    arrayOfNumber = CountPositive(arrayOfNumber);
    ShowArray(arrayOfNumber);
}

main();
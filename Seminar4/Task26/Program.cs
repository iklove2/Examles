/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int GetDigit (int digit)
{
    int numberDigit = 0;
    while(digit != 0)
    {
        digit = digit / 10;
        numberDigit++;
    }
    return numberDigit;
}

Console.Write("Введите число, в которм будем считать цифры: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {number} равно {GetDigit(number)}");

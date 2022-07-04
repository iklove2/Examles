/*
Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetSumOfDigit(int Number = 1)
{
    int sumOfDigit = 0;
    int temporary = Number;
    int divider = 1;
    int TempNum = Number;
    while (TempNum > 0)
    {
        divider = divider * 10;
        temporary = (Number % divider) / (divider / 10);
        sumOfDigit += temporary;
        TempNum = TempNum / 10;
    }
    return sumOfDigit;
}

Console.Write("Введите число А для получения суммы цифр в числе: ");

int NumberFromUser = Convert.ToInt32(Console.ReadLine());
int sumOfDigit = GetSumOfDigit(Number: NumberFromUser);

Console.WriteLine($"{NumberFromUser} -> {sumOfDigit}");
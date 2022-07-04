/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
int GetSumOfRange(int beginNumber = 1, int endNumber = 1)
{
    int sumOfRange = 0;
    for (var i = beginNumber; i <= endNumber; i++)
    {
        sumOfRange += i;
    }
    return sumOfRange;
}

Console.WriteLine("Введите число А для получения суммы от 1 до А");

int endNumberFromUser = Convert.ToInt32(Console.ReadLine());
int sumOfRange = GetSumOfRange(endNumber: endNumberFromUser);

Console.WriteLine($"{endNumberFromUser} -> {sumOfRange}");
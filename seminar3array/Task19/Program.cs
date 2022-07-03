/*
Задача 19: Напишите программу, которая принимает 
на вход пятизначное число и проверяет, 
является ли оно палиндромом.,
Дмитрий Соломонов: 14212 -> нет
23432 -> да
12821 -> да
*/
int IsPalindromNumber(int num)
{
    int delitel = 1;
    int[] digit = new int[5];
    for (int i = 0; i < 5; i++)
    {
        delitel = delitel * 10;
        digit[4 - i] = (num % delitel) / (delitel / 10);
    }
    delitel = 0;
    for (int i = 0; i < 2; i++)
    {
        if (digit[i] == digit[4 - i])
        {
            delitel++;
        }
    }
    return delitel;
}

Console.Write("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int IsPalindrom = 0;
if (number > 10000 && number < 99999)
{
    IsPalindrom = IsPalindromNumber(number);
    if (IsPalindrom == 2)
    {
        Console.WriteLine($"Пятизначное число {number} -> Да, оно палиндром ");
    }
    else
    {
        Console.WriteLine($"Пятизначное число {number} -> Нет, оно не палиндром ");
    }
}
else
{
    Console.Write("Вы ввели не пятизначное число ");
}

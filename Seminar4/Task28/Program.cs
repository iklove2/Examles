/*
Задача 28: Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

int factorial(int number)
{
    int result = 1;
    for(int i = 1; i <= number; i++ )
    {
        result = result*i;
    }
    return result;
}

Console.Write("Введите число N ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Факториал числа {number} равен {factorial(number)}");
/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
*/

int Power(int a, int b)
{
    int power = 1;
    for(int i = 1; i < b; i++)
    {
        power*=a;
    }
    return power;
}


Console.Write("Введите основание степени а... ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите основание степени b... ");
int b = Convert.ToInt32(Console.ReadLine());
int power = Power(a,b);
Console.Write(power);


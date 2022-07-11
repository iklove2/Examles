/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

string ToBinary(int number)
{
    //int[] binary = new int[20];
    int digit = -1;
    string binary = "";
    while (number > 0)
    {
        digit = number % 2;
        number = number / 2;
        binary = digit + binary;
    }
    return binary;
}


Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string binary = ToBinary(Number);
Console.WriteLine($" {Number} -> {binary}");



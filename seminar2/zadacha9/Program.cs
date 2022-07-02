/*
9. Напишите программы , которая выводит случайное число из отрезка [10,99] и показывает наибольшую 
цифру числа
78 -> 8
12 -> 2
85 -> 8
*/
int GetRandomNumber(int minBorder, int maxBroder)
{
    return new Random().Next(minBorder,maxBroder+1);
}

int getMaxDigit(int number)
{
    int maxDigit = 0;
    int digitOne = number / 10;
    int digitTwo = number % 10;
    maxDigit = digitOne;
    if(maxDigit < digitTwo)   
    {
        maxDigit = digitTwo;
    }
    return maxDigit;
}

int randomNumber = GetRandomNumber(10,99);

int maxDigit = getMaxDigit(randomNumber);
Console.WriteLine($"Наибольшая цифра числа {randomNumber} это {maxDigit}");
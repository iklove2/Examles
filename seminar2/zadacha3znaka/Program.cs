int GetRandomNumber(int minBorder, int maxBroder)
{
    return new Random().Next(minBorder,maxBroder+1);
}

int randomnumber = GetRandomNumber(100,999);
Console.WriteLine(randomnumber);
//int number1 = number /100;
int number2 = (number % 100) / 10 
int number3 = number % 10;
string finelnumberstr = Convert.ToString(number1) + Convert.ToString(number3);
int finelnumber = Convert.ToInt32(finelnumberstr);
Console.WriteLine($"{finelnumber}");
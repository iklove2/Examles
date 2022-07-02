Console.Write("Ввведите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Convert.ToString(number).Length != 3)
{
    Console.WriteLine("Число не трехзначное");
}
else
{
    Console.WriteLine(number);
    int number2 = (number % 100) / 10;
    Console.WriteLine($"Для числа {number} вторая цифра {number2}");
}
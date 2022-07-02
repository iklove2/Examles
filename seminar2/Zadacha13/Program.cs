Console.Write("Ввведите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int delitel = 1;
if (Convert.ToString(number).Length < 3)
{
    Console.WriteLine($"Для числа {number} третьей цифры нет");
}
else
{
    int digitn = Convert.ToString(number).Length;
    for (int i = 0 ; i <= digitn - 3; i++)
    {
        delitel = delitel * 10;
    }
    Console.Write(delitel);
    int number3 = (number % delitel) / (delitel/10);
    Console.WriteLine($"Для числа {number} третья цифра {number3}");
}
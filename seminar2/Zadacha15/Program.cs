Console.WriteLine("Узнаем статус дня (выходной не выходной)");
Console.Write("Введите порядковый номер дня недели от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 6)
{
    Console.WriteLine($"День недели с номером {dayNumber} выходной день и это суббота");
}
else if (dayNumber == 7)
{
    Console.WriteLine($"День недели с номером {dayNumber} выходной день и это воскресенье");
}
else if (dayNumber >= 1 && dayNumber < 6)
{
    Console.WriteLine($"День недели с номером {dayNumber} не выходной");
}
else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine($"Дня недели с номером {dayNumber} нет ");
}

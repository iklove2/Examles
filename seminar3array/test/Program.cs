int MaxNumber = 34;
for (var i = 0; i < MaxNumber; i++)
{
    if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    }
    else if (i % 3 == 1)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
    else 
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    Console.Write(i);
    Console.ResetColor();
    if (i != MaxNumber -1)
    {
        Console.Write(",");
    }
}
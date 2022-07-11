/*
Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double xDigit(double b1, double b2, double k1, double k2)
{
    double X = 0;
    X = (b2 - b1) / (k1 - k2);
    return X;
}

double yDigit(double xDigit, double b2, double k2)
{
    double Y = 0;
    Y = xDigit * k2 + b2;
    return Y;
}

void main()
{
    double X = 0;
    double Y = 0;
    Console.Clear();
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    X = xDigit(b1, b2, k1, k2);
    Y = yDigit(X, b2, k2);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");
    Console.ResetColor();
    Console.Write($" -> ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"({Math.Round(X, 2)}; {Math.Round(Y, 2)})");
    Console.ResetColor();
}

main();
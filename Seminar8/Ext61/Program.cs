/*
Задача 61: Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника
*/
void PrintPascal(int N)
{
   // int count = 0;
   for(int e = 0; e < N ; e++)
            {
                Console.Write("  ");
            }
           Console.WriteLine("1");
    for (int np = 1; np <= N; np++)
    {
           for(int e = 0; e < N - np ; e++)
            {
                Console.Write("  ");
            }
        int Cnk = 1;
        Console.Write($"{Cnk}");
        //Console.WriteLine();
        for (int k = 1; k <= np; k++)
        {
            Cnk *= (np - k + 1);
            Cnk /= k;
            Console.Write("  ");
            Console.Write($"{Cnk}");
        }
        Console.WriteLine();
    }
}

Console.Write("Ввкдите N: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintPascal(N);
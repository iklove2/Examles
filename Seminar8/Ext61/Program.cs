/*
Задача 61: Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника
*/


void PrintPascal(int N)
{
    int count = 0;
    for(int i = 1; i <= N; i++)
    {
        
            for(int e = 0; e < N - i; e++)
            {
                Console.Write("  ");
            }
            for(var j = 0; j < i; j++)
            {
                Console.Write($"{j+1}  ");
            }            
            
        Console.WriteLine();
    }
}

Console.Write("Ввкдите N: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintPascal(N);
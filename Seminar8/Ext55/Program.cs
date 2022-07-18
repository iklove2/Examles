/*
Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/
int[,] generateArray(int rowLength, int colLength, int deviation)
{
    int[,] result = new int[rowLength, colLength];
    for (var i = 0; i < rowLength; i++)
    {
        for (var j = 0; j < colLength; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return result;
}

int[,] RotateMatrix(int[,] matrix)
{
    int rowMatrix = matrix.GetLength(0);
    int colMatrix = matrix.GetLength(1);
    //int[,] result = new int[colMatrix, rowMatrix];
    int buffer = 0;
    for(int i = 0; i < rowMatrix; i++)
    {
        for(int j = 0; j < colMatrix; j++)
        {
            buffer = matrix[i,j];
            matrix[j,i] = buffer;
            
        }
    }
    return matrix;
}
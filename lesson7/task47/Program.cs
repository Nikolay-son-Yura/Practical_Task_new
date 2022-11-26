﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * (1-10)+5;// последнию цифру посоветовали добавить но зачем она не разобрался
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write("{0:f1}", array[i, j]);
            System.Console.Write(" ");
        }
        System.Console.WriteLine();
    }
}

int m = 3;
int n = 4;
double[,] array = new double[m, n];
FillArray(array);
PrintArray(array);

//тут не только отрицательные,но рандомит чаще с "-" почему то
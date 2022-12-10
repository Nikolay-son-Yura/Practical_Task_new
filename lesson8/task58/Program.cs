﻿// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//метод для получения матрицы из консоли
int[,] GetMatrixFromConsole(string name)
{
    Console.Write("Количество строк матрицы {0}: ", name);
    var n = int.Parse(Console.ReadLine()!);
    Console.Write("Количество столбцов матрицы {0}: ", name);
    var m = int.Parse(Console.ReadLine()!);

    var matrix = new int[n, m];
    for (var i = 0; i < n; i++)
    {
        for (var j = 0; j < m; j++)
        {
            Console.Write("{0}[{1},{2}] = ", name, i, j);
            matrix[i, j] = int.Parse(Console.ReadLine()!);
        }
    }

    return matrix;
}

// метод для печати матрицы в консоль
void PrintMatrix(int[,] matrix)
{
    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        for (var j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j].ToString().PadLeft(4));
        }

        Console.WriteLine();
    }
}

// метод для умножения матриц
int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (var i = 0; i < matrixA.GetLength(0); i++)
    {
        for (var j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (var k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
}

void Main(string[] args)
{
    Console.WriteLine("Программа для умножения матриц");

    var a = GetMatrixFromConsole("A");
    var b = GetMatrixFromConsole("B");

    Console.WriteLine("Матрица A:");
    PrintMatrix(a);

    Console.WriteLine("Матрица B:");
    PrintMatrix(b);

    var result = MatrixMultiplication(a, b);
    Console.WriteLine("Произведение матриц:");
    PrintMatrix(result);

    Console.ReadLine();
}

Main(args);

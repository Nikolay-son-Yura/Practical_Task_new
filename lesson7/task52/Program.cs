// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int rows = 3;
int cols = 4;
int[,] massive = new int[rows, cols];
FillArray(massive);
PrintArray(massive);
double element = massive[0, 0];
double sum = 0;
int count = 1;
for (int k = 0; k < cols; k++)
{

    for (int i = 0; i < rows; i++)
    {

        element = massive[i, k];
        element /= rows;
        sum += element;

    }
    System.Console.WriteLine($"среднее арифмитическое {count}го столбца = {Math.Round(sum, 1)}");
    sum = 0;
    count++;
}










//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

int rows = new Random().Next(2,11);
int cols = new Random().Next(2,11);
int[,] massive = new int[rows, cols];
FillArray(massive);
// PrintArray(massive); //проверка для себя
Console.Write("введите индекс через запятую ");
string[] strings = Console.ReadLine()!.Split(',');
int[] array = new int[strings.Length];
for (int i = 0; i < strings.Length; i++)
{
    array[i] = int.Parse(strings[i]);
}
int rows1 = array[0];
int cols1 = array[1];
PrintArray(massive);

if (rows == rows1 && cols == cols1)
{
    System.Console.WriteLine("элимент не найден");
}
else if(rows < rows1 || cols < cols1)
{
    System.Console.WriteLine("элимент не найден");
}
else
{
    System.Console.WriteLine($"элимент найден {massive[rows1,cols1]}");
}
   
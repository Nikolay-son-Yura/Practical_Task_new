// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(" ", array));
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(99, 1000);
        index++;
    }
}

Console.Write("Введите длину массива:  ");
int num = int.Parse(Console.ReadLine()!);
int[] massive = new int[num];
int even = 0;
FillArray(massive);
PrintArray(massive);
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i] % 2 == 0)
    {
        even++;

    }
}
Console.Write($"{even} четных");

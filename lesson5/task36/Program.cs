// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        collection[index] = new Random().Next(0, 10);
        index++;
    }
}

Console.Write("Введите длину массива:  ");
int num = int.Parse(Console.ReadLine()!);
int[] massive = new int[num];
FillArray(massive);
PrintArray(massive);

int sum = 0;
for (int i = 0; i < massive.Length; i++)
{
    if (i % 2 == 0)
    {
        sum += massive[i];
    }
}
System.Console.WriteLine(sum);


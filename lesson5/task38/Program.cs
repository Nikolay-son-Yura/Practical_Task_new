//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}

int MaxElement(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

int MinElement(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {

        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}
Console.Write("Введите длину массива:  ");
int num = int.Parse(Console.ReadLine()!);
int[] massive = new int[num];
FillArray(massive);
PrintArray(massive);

System.Console.WriteLine(MaxElement(massive)-MinElement(massive));




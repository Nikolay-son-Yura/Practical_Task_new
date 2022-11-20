// Дан массив. Найдите MEX массива. MEX (Minimum EXcluded) - минимальный отсутствующий элемент.
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
        collection[index] =  new Random().Next(0, 10);
        index++;
    }
}

Console.Write("Введите длину массива:  ");
int num = int.Parse(Console.ReadLine()!);
int[] massive = new int[num];
FillArray(massive);
PrintArray(massive);

int GetMEX(int[] array) // подсмотрел у гугла
{
    for (int mex = 0; mex < array.Length; mex++)
    {
        bool notFound = true;
        for (int i = 0; i < array.Length; i++)
        {
        
            if (array[i] == mex)
            {
                notFound = false;
                break;
            }
        }
        if (notFound)
        {
            return mex;
        }
    }
    return array.Length;//вот тут непонятно зачем возвращать длину массива
}

System.Console.WriteLine(GetMEX(massive));
// Дан массив чисел. Напишите функцию, которая ищет заданное число в массиве и показывает нужный индекс в нем. При отсутствии числа возвращать -1.



// нет уточнения какой индекс показывать если искомые элименты повторяются
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

void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(" ", array));
}

int DesiredElement(int[] array, int desired)
// первый элимент
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == desired)
        {
            return i;  
        }
    }
    return -1;
}
// последний элимент
// {
//     int position =0;
//     int i =0;
//     while( i<array.Length)
//     {
//         if(array[i]==desired)
//         {
//             position=i;
//         }
//         i++;
//     }
//     return position;
// }
//если все индексы

System.Console.WriteLine("Введите длину массива:  ");
int num = int.Parse(Console.ReadLine()!);
int[] massive = new int[num];
FillArray(massive);
PrintArray(massive);
System.Console.WriteLine("введите элимент искомый в массиве : ");
int desired = int.Parse(Console.ReadLine()!);
int index = DesiredElement(massive, desired);
System.Console.WriteLine(index);
//если все индексы  (в функцию не смог запихнуть) 2 строчки над закоментить
// int i = 0;
// while(i<massive.Length)
// {
//     if(massive[i]== desired)
//     {
//         System.Console.WriteLine($"{i} ");
//     }
//     i++;
// }

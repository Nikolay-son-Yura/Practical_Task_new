// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write(element);
}
Console.Write("Введите длину массива:  ");
int num = int.Parse(Console.ReadLine()!);
int num1 =1;
int[] array = new int[num];
while(num1<=num)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {num1} элемент масива:  ");
        array[i]=int.Parse(Console.ReadLine()!);
        num1++;
    }
    //num1++;
}


System.Console.WriteLine("Ваш массив ");
PrintArray(array);
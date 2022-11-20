// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(" ", array));
}
Console.Write("введите ваши числа через запятую ");
string[] strings = Console.ReadLine()!.Split(',');// это рассказали в другой группе
int[] array = new int[strings.Length];
for(int i=0;i<strings.Length;i++ )
{
    array[i] = int.Parse(strings[i]);
}

PrintArray(array);

int counter=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        counter++;
        System.Console.Write(counter);
    }
}
//System.Console.Write($"=> {counter}({array[i]}");

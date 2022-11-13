// Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.
// 11 -> 2, 3, 5 , 7, 11   
Console.Write("Введите число N ");
int num = int.Parse(Console.ReadLine()!);
bool Simple(int num)
{
    for (int i = 2; i <= num / 2; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}

for (int i = 2; i <= num; i++)
{
    if (Simple(i))// if (true) такое условие 
    {
        Console.WriteLine(i);
    }
}
        


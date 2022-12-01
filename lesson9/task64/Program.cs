// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Rec(int n)
{
    if (1 <= n)
    {
        System.Console.Write(n + ", ");
        Rec(n-1);
    }
    return;
}
Console.Write("N = ");
int n = int.Parse(Console.ReadLine()!);
Rec(n);
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int SumNumbers(int M, int N)
{ 
    if (M <= N)
    {
        return N + SumNumbers(M, N - 1);
    }
    else
    {
        return 0;
    }
}

Console.Write("M = ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("N = ");
int N = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(SumNumbers(M, N));




//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите  число А:  ");
int numA = int.Parse(Console.ReadLine()!);
Console.Write("Введите  число В:  ");
int numB = int.Parse(Console.ReadLine()!);
int num = numA;
int num1 = 1;
while (num1 < numB)
{
    numA = numA * num;
    num1++;
}
Console.WriteLine($"{num}^{numB}={numA}");
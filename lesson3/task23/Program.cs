/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Write("Введите число N ");
int num = int.Parse(Console.ReadLine()!);
int num1 = 1;
while (num1 <= num)
{
    int num2 = num1 * num1 * num1;
    Console.WriteLine($"{num1}^3 = {num2} ");
    num1++;
}
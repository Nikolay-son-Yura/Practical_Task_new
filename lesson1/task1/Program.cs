/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите 1е число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2е число");
int num2 = int.Parse(Console.ReadLine()!);
int max = 0;
if(num1>num2)
{
    max = num1;
}
else
{
    max = num2;
}
System.Console.WriteLine($"max = {max}");
/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Введите трехзначное число  ");
int num = int.Parse(Console.ReadLine()!);
if( 100<num && num<999)
{
    int num2 = (num % 100) / 10;
Console.WriteLine(num2);
}
else
{
    System.Console.WriteLine("Трехзначное пожалуйста");
}

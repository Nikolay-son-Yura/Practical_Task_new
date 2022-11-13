/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
№1 - третья цифра с конца
№2 - третья цифра с начала
*/
//№1
// Console.Write("Введите число  ");
// int num = int.Parse(Console.ReadLine()!);

// if (num < 100)
// {
//     Console.WriteLine("Третья цифра числа не найдена");
// }
// else
// {
//     int num2 = (num % 1000) /100;
//     Console.WriteLine($"третья цифра с конца = {num2}");
// }
//№2
Console.Write("Введите число  ");
int num = int.Parse(Console.ReadLine()!);
if (num < 100)
{
    Console.WriteLine("Третья цифра числа не найдена");
}
else
{
    while (num>1000)
    {
        num = num /10;
    }
}
num= num % 10;
Console.WriteLine($"третья цифра с начала = {num}");
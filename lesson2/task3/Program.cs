/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
// можно так
// Console.Write("Задайте номер дня недели ");
// int num = int.Parse(Console.ReadLine()!);
// if(num == 1)
// {
//     Console.Write("понедельник-нет"); 
// }
// if(num == 2)
// {
//     Console.Write("вторник-нет"); 
// }
// if(num == 3)
// {
//     Console.Write("среда-нет"); 
// }
// if(num == 4)
// {
//     Console.Write("четверг-нет"); 
// }
// if(num == 5)
// {
//     Console.Write("пятница-нет"); 
// }
// if(num == 6)
// {
//     Console.Write("суббота-да"); 
// }
// if(num == 7)
// {
//     Console.Write("воскресенье-да"); 
// }
// else
// {
//     Console.WriteLine("такого дня нет");
// }
// а можно так
Console.Write("Задайте номер дня недели ");
int num = int.Parse(Console.ReadLine()!);
if (num >= 1 && num <= 7)
{
    if/*(num ==6 && num == 7)*/(num >= 6)
    {
        Console.WriteLine(" да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("такого дня нет");
}


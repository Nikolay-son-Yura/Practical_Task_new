/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/
void Multiplicity(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        System.Console.WriteLine("да");
    }
    else
    {
        System.Console.WriteLine("нет");
    }
}

Console.Write("Введите число  ");
int num = int.Parse(Console.ReadLine()!);
Multiplicity(num);

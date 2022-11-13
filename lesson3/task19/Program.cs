/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// Console.Write("введите пятизначное число : ");// тут условия говорит что только 5ти значное число и никакое другое
// int num = int.Parse(Console.ReadLine()!);

// int num5= num %10;
// num = num/10;
// int num4= num %10;
// num = num/10;
// int num3= num %10;
// num = num/10;
// int num2= num %10;
// num = num/10;
// int num1= num %10;
// num = num/10; 

// if(num5==num1 && num4==num2)
// {
//     System.Console.WriteLine("полиндром");
// }
// else
// {
//     System.Console.WriteLine("не полиндром");
// }

// тут через массив

void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write(element);
}

Console.Write("введите пятизначное число : ");// тут условия говорит что только 5ти значное число и никакое другое,но на всякий случай
int num = int.Parse(Console.ReadLine()!);
int number = num;
int num1 = 0;
if (number < 100000 && number > 10000)
{
    int[] array = new int[5];
    int lengt = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        num1 = number % 10;
        array[i] = num1;
        number = number / 10;
    }
    Array.Reverse(array);
    PrintArray(array);
    if (array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine(" число является палиндромом");// у мен тут вопрос не разобрался сам,если сделать так ' $"{num} число является палиндромом" 'то num двоит
    }
    else
    {
        Console.WriteLine(" число не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("внимательнее");
}










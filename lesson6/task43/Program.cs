// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(" ", array));
}
Console.Write("введите ваши  через запятую k1,b1 и k2,b2 ");
string[] strings = Console.ReadLine()!.Split(',');
int[] array = new int[strings.Length];
for (int i = 0; i < 4; i++)
{
    array[i] = int.Parse(strings[i]);

}

PrintArray(array);
double k1 = array[0];//5
double b1 = array[1];//2
double k2 = array[2];//9
double b2 = array[3];//4
double x = -(b1-b2)/(k1-k2);
double y = k1*x+b1;


Console.WriteLine($"Пересечение в точке: ({x};{y})");


/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
// */
// Console.Write("введите пятизначное число : ");
// int num = int.Parse(Console.ReadLine()!);
int Vec(int a1, int a2)
{
    int vecX = 0;
    if (a1 > a2)
    {
        vecX = a1 - a2;
    }
    else
    {
        vecX = a2 - a1;
    }
    return vecX;
}
int Square(int num)
{
    num = num * num;
    return num;
}
System.Console.WriteLine("Введите координаты точки A по оси Х");
int x1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координаты точки A по оси Y");
int y1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координаты точки A по оси Z");
int z1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координаты точки B по оси Х");
int x2 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координаты точки B по оси Y");
int y2 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координаты точки B по оси Z");
int z2 = int.Parse(Console.ReadLine()!);
int vecX = Vec(x1, x2);
int vecY = Vec(y1, y2);
int vecZ = Vec(z1, z2);
int dist = Square(vecX) + Square(vecY) + Square(vecZ);
double dist3 = Math.Sqrt(dist);
System.Console.WriteLine($"растояние между точкой А({x1},{y1},{z1}) и точкой Б({x2},{y2},{z2}) в 3Д пространстве = {dist3}");
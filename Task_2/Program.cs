// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату X первой точки");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y первой точки");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z первой точки");
int za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату X второй точки");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y второй точки");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z второй точки");
int zb = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt (Math.Pow ((xb - xa), 2) + Math.Pow ((yb - ya), 2) + Math.Pow ((zb - za), 2));
Console.WriteLine($"{result:f2}");

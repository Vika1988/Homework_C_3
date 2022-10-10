// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()!);
int m = 1;


if(n < 1)
{
    Console.Write("Вы ввели некорректное число n");
}
else
{
    for (m = 1; m < n; m++)
    {
        Console.Write($"{Math.Pow(m, 3)}, ");
    }
    Console.WriteLine($"{Math.Pow(m, 3)} ");
}

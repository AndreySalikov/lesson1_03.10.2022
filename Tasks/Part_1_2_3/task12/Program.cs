// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Lesson 3
// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 
// и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateCoords(int xCoord, int yCoord)
{
    if (xCoord == 0 || yCoord == 0)
    {
        Console.WriteLine("Точка находиться как минимум на одной из осей.");
        return false;
    }
    return true;
}

int GetQuartet(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x > 0 && y < 0) return 4;
    if(x < 0 && y > 0) return 2;
    return 3;
}

int x = Prompt("Введите Х > ");
int y = Prompt("Введите Y > ");

if (!ValidateCoords(x, y))
{
    return;
}

if (x > 0 && y > 0)
{
    System.Console.WriteLine("1 четверть");
}
if (x > 0 && y < 0)
{
    System.Console.WriteLine("4 четверть");
}
if (x < 0 && y > 0)
{
    System.Console.WriteLine("2 четверть");
}
if (x < 0 && y < 0)
{
    System.Console.WriteLine("3 четверть");
}

System.Console.WriteLine($"{GetQuartet(x, y)} четверть");

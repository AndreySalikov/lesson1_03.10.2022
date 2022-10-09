// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// Math.Sqrt() // команда квадратный корень

/* */

Console.Clear();

const int X = 0;
const int Y = 1;

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputPoint(int point)
{
    int[] answer = new int[2];
    answer[X] = Prompt($"Введите Х  {point} -> ");
    answer[Y] = Prompt($"Введите Y  {point} -> ");
    return answer;
}

// int Power2(int arg)
double Power2(int arg)
{
    // return arg * arg;
    return Math.Pow(arg, 2);
}

int[] p1 = InputPoint(1);
int[] p2 = InputPoint(2);

double lenght = Math.Sqrt(Power2(p1[X] - p2[X]) + Power2(p1[Y] - p2[Y])); // <- Math.Sqrt() команда квадратный корень
System.Console.WriteLine($"{lenght:f2}"); // :f.. кол-во символов после запятой

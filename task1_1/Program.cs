// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да
// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine ("Введите первое число: ");
int a = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine ("Введите первое число: ");
int b = int.Parse (Console.ReadLine() ?? "0");
if (a == b*b)
{
    Console.WriteLine($"Число {a} являеться квадратом {b}");
}
else if (b == a*a)
{
    Console.WriteLine($"Число {b} являеться квадратом {a}");
}
else
{
    Console.WriteLine($"Числа не являються квадратами друг друга");
}
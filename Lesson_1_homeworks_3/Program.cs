// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 != 0)
{
    System.Console.WriteLine($"{n} нечетное");
}
else
{
    System.Console.WriteLine($"{n} четное");
}
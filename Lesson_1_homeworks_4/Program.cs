// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 0)
{
    System.Console.WriteLine("Введите положительно число, которое будет больше нуля");
}
int Count = 2;
while (Count <= N)
{
    if (Count % 2 == 0) {Console.Write(Count + " ");}
    Count++;
}
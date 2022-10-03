// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(a > b || a == b)
{
    max = a;
}
else 
{
    max = b;
}
if(c > max || c == max) 
{
    max = c;
}
    System.Console.WriteLine($" Вы ввели {a}, {b}, {c} - Максимальное из них = {max}");

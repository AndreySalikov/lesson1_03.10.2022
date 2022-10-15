// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int random = new Random().Next(10, 99);
System.Console.WriteLine(random);
int a = random % 10;
int b = random / 10;
if(a == b)
{
    System.Console.WriteLine("Первое и второе числа одинаковы");
}
if(a < b)
{
    System.Console.WriteLine($"Наибольшая цифра числа {random} {b}");
}
else
{
    System.Console.WriteLine($"Наибольшая цифра числа {random} {a}");
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

System.Console.WriteLine("Ввудите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a % b == 0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine($"не кратно, остаток от деления {a % b}");
}
// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();

System.Console.WriteLine("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());
int sumNumber = a;

for(int i = 0; i < a; i++)
{
    sumNumber += i;
}

System.Console.WriteLine(sumNumber);
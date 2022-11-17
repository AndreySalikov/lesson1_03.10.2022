// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. 
// Использовать рекурсию.
// 453 -> 12
// 45 -> 9
int Recursion(int n)
{
    if(n <= 0) return 0;
    else return n % 10 + Recursion(n / 10);
}

int n = 1111;

System.Console.Write(Recursion(n));

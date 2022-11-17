// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 1: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


void Recursion(int n)
{
    if(n <= 0) return;
    Recursion(n - 1);
    System.Console.Write(n + " ");
}

int n = 6;
Recursion(n);
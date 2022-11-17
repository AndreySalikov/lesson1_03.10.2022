// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: Задайте значения M и N. 
// Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Recursion(int n, int m)
{
    if(n > m) return;
    Recursion(n,m-1);
    System.Console.Write(m + " ");
}

int n = 1;
int m = 10;
Recursion(n,m);
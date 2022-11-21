// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.Clear();

void Recursion(int n, int m)
{
    if(n > m) return;
        Recursion(n,m-1);
        if (m % 2 == 0)
        System.Console.Write(m + " ");
        else return;
}

int n = 4;
int m = 8;
Recursion(n,m);

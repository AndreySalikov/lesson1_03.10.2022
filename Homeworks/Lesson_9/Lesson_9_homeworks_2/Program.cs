// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();


void SumNumber (int m, int n, int sum )
{
    if (m > n) 
    {
        Console.WriteLine($"Sum from M to N: {sum}"); 
        return;
    }   
    sum = sum + (m++);
    SumNumber(m, n, sum);
}

int sum = 0;
int m = 9;
int n = 10;
SumNumber(m, n, sum);
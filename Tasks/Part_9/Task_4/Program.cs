// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 4: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Recursion(int n, int m)
{
    if(m <= 0) return 1;
    else return n * Recursion(n, m-1);
}

int n = 2;
int m = 5;

System.Console.Write(Recursion(n, m));
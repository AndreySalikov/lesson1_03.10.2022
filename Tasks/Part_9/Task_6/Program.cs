// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 6: Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”
bool Recursion(int n, int m)
{
    if(m <= 1) return true;
    else return (n % (m) != 0) && (Recursion(n, m - 1));
}

int n = 19927;
System.Console.Write(Recursion(n, n - 1));
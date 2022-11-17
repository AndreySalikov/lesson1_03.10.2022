// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 5: Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”
bool Recursion(int n)
{
    if(n <= 2) return true;
    else return (n % 2 == 0) && (Recursion(n / 2));
}

int n = 16;

System.Console.Write(Recursion(n));
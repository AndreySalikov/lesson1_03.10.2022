// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Напишите программу вычисления функции:
//  x = f(a)

Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int f = 1;
int x = 1;
while (f == n); f++;
{
    x = x + n * f;   
}
Console.WriteLine($"Факториал числа {n} = {x}");

int Factorial(int n)
{
    if (n == 1) return 1;
 
    return n * Factorial(n - 1);
}

int factorial_n = Factorial(n);

Console.WriteLine($"Факториал числа {n} = {factorial_n}");

int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n;
     
    return Fibonachi(n - 1) + Fibonachi(n - 2);
}
 
int fib4 = Fibonachi(4);
int fib5 = Fibonachi(5);
int fib6 = Fibonachi(6);
 
Console.WriteLine($"4 число Фибоначчи = {fib4}");
Console.WriteLine($"5 число Фибоначчи = {fib5}");
Console.WriteLine($"6 число Фибоначчи = {fib6}");

static int Fibonachi2(int n)
{
    int result = 0;
    int b = 1;
    int tmp;
 
    for (int i = 0; i < n; i++)
    {
        tmp = result;
        result = b;
        b += tmp;
    }
 
    return result;
}

int ni = 5;  // количество циклов в факториале
int factorial = 1;   // значение факториала

for (int i = 2; i <= ni; i++) // цикл начинаем с 2, т.к. нет смысла начинать с 1
{
     factorial = factorial * i;
}
Console.WriteLine($" {factorial}");
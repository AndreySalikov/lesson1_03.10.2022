// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();

int Prompt (string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Fibonacci(int number)
{
    int count = number;
    int f0 = 0;
    int f1 = 1;

    while (count > 0)
    {
        int result = f0 + f1;
        System.Console.Write($"{f0}\t");
        f0 = f1;
        f1 = result;
        count--;
    }
}

int number = Prompt("Введите число: ");
Fibonacci(number);

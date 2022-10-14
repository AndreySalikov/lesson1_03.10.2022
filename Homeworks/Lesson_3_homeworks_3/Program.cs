// Lesson 3
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int N = Prompt("Enter number: ");
for(int i = 1; i <= N; i++)
{
    System.Console.WriteLine(Math.Pow(i,3)); // возведение в степень
}
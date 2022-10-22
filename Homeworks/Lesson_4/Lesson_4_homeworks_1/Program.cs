// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Enter number A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number B: ");
int B = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"You entered nombers {A} and {B}");
if (B >= 0)
{
    int result = 1;
    for (int index = 0; index < B; index++)
    {
        result = result * A;
    }
    System.Console.WriteLine($"{A} to the power of {B} is {result}");
}
else
{
    System.Console.WriteLine($"{B} is not a natural number!");
}
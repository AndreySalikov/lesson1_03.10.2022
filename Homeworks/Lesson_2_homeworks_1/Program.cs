// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//  Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

int Promt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidationNumber (int number)
{
    if (number < 100 || number > 999)
    {
        Console.WriteLine("Вы ввели не трехзначное число, поторите ввод!");
        return false;
    }
    return true;
}

int number = Promt("Введите число: ");

if (!ValidationNumber(number))
{
    return;
}

System.Console.WriteLine($"Вторая цифра числа {number} это {number / 10 % 10}");
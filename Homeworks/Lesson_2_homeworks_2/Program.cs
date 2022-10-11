// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//  Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();

int Promt()
{
    int number = Convert.ToInt32(new Random().Next(99,1000));
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

int number = Promt();

if (!ValidationNumber(number))
{
    return;
}

Console.WriteLine($"Число {number} без второй цифры это {number / 100 % 10 }{number % 10}");
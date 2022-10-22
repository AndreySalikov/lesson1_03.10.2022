// Lesson 3
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();

int Module(int module)
{
    if (module < 0)
    {
        module = -module;
    }
    return module;
}

int Promt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidationNumber (int number)
{
    if (number < 10000 || number > 99999 )
    {
        Console.WriteLine("You entered a non-five-digit number");
        return false;
    }
    return true;
}

bool IsPalindrome(int number)
{
    int reverse = 0;
    int origNumber = number;
    while (number > 0)
    {
        int value = number % 10;
        reverse = reverse * 10 + value;
        number = number / 10;
    }
    return origNumber == reverse;
}

int number = Promt("Enter five-digit number: ");
number = Module(number);
if (!ValidationNumber(number))
{
    return;
}
if (IsPalindrome(number))
{
    System.Console.WriteLine("This number is a palindrome");
}
else
{
    System.Console.WriteLine("This number isn't a palindrome");
}


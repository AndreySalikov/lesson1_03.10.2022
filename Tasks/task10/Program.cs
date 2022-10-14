// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Clear();

int Prompt(string mesg)
{
    System.Console.WriteLine(mesg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = Prompt("Введите число: ");

// System.Console.WriteLine("Ввудите число");
// int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0)
{
    System.Console.WriteLine($"да ");
}
else
{
    System.Console.WriteLine($"нет ");
}
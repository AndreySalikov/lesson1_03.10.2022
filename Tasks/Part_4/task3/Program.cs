// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();

int Module(int module)
{
    if (module < 0)
    {
        module = -module;
    }
    return module;
}

int InputPoint(string message) // Ввод числа по приглашению
{
    Console.Write(message); // Вывод приглашения \ сообщения
    string str = Console.ReadLine(); //Читаем строку из консоли
    return Convert.ToInt32(str); // Преобразуем строку в число
}
// Факториал чисел от 1 до Number (Параметр)
int Factorial(int number)
{
    int multiply = 1;
    for(int i = 1; i <= number; i++)
    {
        multiply = multiply * i;
    }
    return multiply;
}

int number = InputPoint("Enter number: ");
System.Console.WriteLine($"Factorial of {number} is {Factorial(number)} digits");
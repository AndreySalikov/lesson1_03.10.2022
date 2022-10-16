// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 1: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

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
// Сумма чисел от 1 до Number (Параметр)
int CountNumbers(int number)
{
    int count = 0; // тут накапливаем кол-во
    while(number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

int number = InputPoint("Enter number: ");
System.Console.WriteLine($"{number} has {CountNumbers(Module(number))} digits");

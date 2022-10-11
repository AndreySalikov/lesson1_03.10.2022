// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//  Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. 
// Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

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
    if (number < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return false;
    }
    return true;
}

int number = Promt("Введите число: ");
int thirdNumber = 0;
number = Module(number);

if (ValidationNumber(number))
{
    while (number >= 1000)
    {
        number = number / 10;
    }
    thirdNumber = number % 10;
    Console.WriteLine($"Третья цифра {thirdNumber}");
}
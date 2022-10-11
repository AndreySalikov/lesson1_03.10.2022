// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

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

bool ValidationNumberDay (int number)
{
    if (number > 7 || number < 1)
    {
        Console.WriteLine("Такого дня недели не существует");
        return false;
    }
        if (number > 5)
        {
            Console.WriteLine($"Выходной");
        }
        else
        {
            Console.WriteLine($"Будний");
        }   
    return true;
}

int numberDay = Promt("Введите день недели: ");
numberDay = Module(numberDay);
ValidationNumberDay(numberDay);

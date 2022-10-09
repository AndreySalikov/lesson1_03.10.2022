// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Lesson 3
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateQuartet(int Quartet)
{
    if (Quartet < 1 || Quartet > 4)
    {
        Console.WriteLine("Вы ввели не правильную четверть!");
        return false;
    }
    return true;
}


string GetCoords2(int Quartet)
{
    switch (Quartet)
    {
        case 1:
        return "x > 0 && y > 0";
        case 2:
        return "x > 0 && y < 0";
        case 3: 
        return "x < 0 && y < 0";
        default:
        return "x < 0 && y > 0";
    }

}

int Quartet = Prompt("Введите номер четверти: ");


if (!ValidateQuartet(Quartet))
{
    return;
}

if(Quartet == 1) 
{
    System.Console.WriteLine ("x > 0 && y > 0");
}
if(Quartet == 2) 
{
    System.Console.WriteLine ("x > 0 && y < 0");
}
if(Quartet == 3) 
{
    System.Console.WriteLine ("x < 0 && y < 0");
}
if(Quartet == 4) 
{
    System.Console.WriteLine ("x < 0 && y > 0");
}


System.Console.WriteLine($"{GetCoords2(Quartet)}");



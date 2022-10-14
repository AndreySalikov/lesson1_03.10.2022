// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да
// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

int Prompt(string message)
{
    System.Console.Write(message);
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int numbre_1 = Prompt("Введите первое число > ");
int numbre_2 = Prompt("Введите второе число > ");
int square = numbre_1 * numbre_1;
if (square == numbre_2){
    System.Console.WriteLine($"Квадрат числа {numbre_1} равен {numbre_2}");
}
else{
    System.Console.WriteLine($"Квадрат числа {numbre_1} не равен {numbre_2}");
}

// See https://aka.ms/new-console-template for more information
// 
// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа
// 7812 -> 8
// 1213 -> 3
// 845 -> 8

Console.Clear();

// int random = new Random().Next(10, 9999);
// System.Console.WriteLine(random);

// int Prompt(string mesg)
// {
//     System.Console.WriteLine(mesg);
//     int number = new Random().Next(10, 9999);
//     return number;
// }

int random = new Random().Next(10, 9999);
System.Console.WriteLine($"Генератор создал число: {random}");
int WriteRandom = random;
int max = random % 10;
while (random > 0)
{
    int temp = random % 10;
    if (temp > max)
    {
        max = temp;
    }    
    random = random / 10;    
}
System.Console.WriteLine($"{max} наибольшая цифра числа - {WriteRandom}");
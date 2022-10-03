// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.WriteLine("Введите первое число: ");
int b = int.Parse(Console.ReadLine() ?? "0");
if(a == b * b)
{
    Console.WriteLine("Число "+a+ "являеться квадратом" +b+".");
}
else if(b == a * a)
{
    Console.WriteLine($"Число {b} являеться квадратом {a}.");
}
else
{
    Console.WriteLine($"Числа не являються квадратами друг друга");
}
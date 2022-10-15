// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

System.Console.WriteLine("Введи трехзначное число");
int N = Convert.ToInt32(Console.ReadLine());


if(N < 100 || N > 999)
{
    System.Console.WriteLine("Вы ввели не трехзначное число!");
}
else
{
    int Count = N % 10;
    Console.Write(Count);
}

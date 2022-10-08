// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int [] array = {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};

int max = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
}

System.Console.WriteLine($"Максимальное = {max}");

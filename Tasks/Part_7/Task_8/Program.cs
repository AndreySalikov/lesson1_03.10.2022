// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// выведите число 

int Prompt (string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt("Enter ");

for (int i = 1; i <= number; i++)
{
    for (int j = 0; j < i; j++)
    {
        System.Console.Write($"{i}\t");
    }
}
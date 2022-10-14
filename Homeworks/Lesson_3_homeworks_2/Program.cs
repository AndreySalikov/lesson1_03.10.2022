// Lesson 3
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

const int X = 0;
const int Y = 1;
const int Z = 2;

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputPoint(int point)
{
    int[] answer = new int[3];
    answer[X] = Prompt($"Enter X  {point} -> ");
    answer[Y] = Prompt($"Enter Y  {point} -> ");
    answer[Z] = Prompt($"Enter Z  {point} -> ");
    return answer;
}

void FillArray (int[] collection)
{
    int length = collection.Length; 
    int index = 0;
    while (index < length)
    {
        collection[index] = Convert.ToInt32(new Random(). Next(99, 199));
        index = index +1; // index++
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        System.Console.Write(collection[index] + ", ");
        index++;
    }
}

// int Power2(int arg)
double Power2(int arg)
{
    // return arg * arg;
    return Math.Pow(arg, 2); // <- Math.Pow() возведение в степень
}

int[] p1 = InputPoint(1);
int[] p2 = InputPoint(2);

PrintArray(p1);
System.Console.WriteLine();
PrintArray(p2);
System.Console.WriteLine();

double lenght = Math.Sqrt(Power2(p2[X] - p1[X]) + Power2(p2[Y] - p1[Y]) + Power2(p2[Z] - p1[Z])); // <- Math.Sqrt() команда квадратный корень
System.Console.WriteLine($"{lenght:f2}"); // :f.. кол-во символов после запятой
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
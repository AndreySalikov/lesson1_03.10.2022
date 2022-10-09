// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

string a;
int[] b = new int[100];
int i=0;
while ((a = Console.ReadLine()) != "end") //Получаем строку и проверяем ее содержание
    b[i++] = Convert.ToInt32(a); //в стркое нет "конца" - значит конвертим и пишем в массив

for (int k = 0; k < i; k++) //вывод заполненных ячеек массива
    Console.WriteLine(b[k]);

Console.ReadKey(true);
// Lesson 3
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();

// int Module(int module)
// {
//     if (module < 0)
//     {
//         module = -module;
//     }
//     return module;
// }

int Promt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// bool ValidationNumber (int number)
// {
//     if (number < 10000 || number > 99999 )
//     {
//         Console.WriteLine("Выввели не пятизначное число");
//         return false;
//     }
//     return true;
// }

// int number = Promt("Введите пятизначное число: ");
// number = Module(number);
// ValidationNumber(number);


int[] array = new int[5];
int i=0;
// while ((a = Console.ReadLine()) != "end") //Получаем строку и проверяем ее содержание
while (array[i] != array[5])   
    int number = Convert.ToInt32(Console.ReadLine());
    array[i++] = number; //в стркое нет "конца" - значит конвертим и пишем в массив

for (int k = 0; k < i; k++) //вывод заполненных ячеек массива
    Console.Write(array[k]);

Console.ReadKey(true);

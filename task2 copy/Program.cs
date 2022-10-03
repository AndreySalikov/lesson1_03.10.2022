// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine() ?? "0");
// string [] days = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
// if(day < 1 || day > 7)
// {
//     Console.WriteLine("Такого дня недели не существует!");
// }
// else
// {
//     Console.WriteLine(days [day -1]);
// }

switch (day)
{
    case 1: Console.WriteLine("Понедельник");
    break;
    case 2: Console.WriteLine("Вторник");
    break;
    case 3: Console.WriteLine("Среда");
    break;
    case 4: Console.WriteLine("Четверг");
    break;
    case 5: Console.WriteLine("Пятница");
    break;
    case 6: Console.WriteLine("Суббота");
    break;
    case 7: Console.WriteLine("Воскресенье");
    break;
}
// Задачи семинар 1 C#:
// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3 b = 9 -> нет

// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 ->  Пятница

// 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
 
// Console.WriteLine("Введите число: ");
// string number0 = Console.ReadLine();
// int numberA = Convert.ToInt32(number0);
// Console.WriteLine("Введите число: ");
// string number1 = Console.ReadLine();
// int numberB = Convert.ToInt32(number1);
// if (numberA == numberB * numberB)
// {
//     Console.Write("А является квадратом B");
// }
// else
// {
//     Console.Write("А не является квадратом B");
// }

// Console.WriteLine("Введите число:");
// string number = Console.ReadLine();
// int numberA = Convert.ToInt32(number);
// int numberB = numberA * -1;
// while (numberB <= numberA)
// {
//     Console.Write(numberB);
//     numberB++;
    
// }

Console.WriteLine("2 задача");
Console.Write("Введите номер дня недели: ");
string text = Console.ReadLine();
int numberDayOfWeek = Convert.ToInt32(text);


if (numberDayOfWeek == 1)
{
    Console.WriteLine("Понедельник");
}
else if (numberDayOfWeek == 2)
{
    Console.WriteLine("Вторник");
}
else if (numberDayOfWeek == 3)
{
    Console.WriteLine("Среда");
}
else if (numberDayOfWeek == 4)
{
    Console.WriteLine("Четверг");
}
else if (numberDayOfWeek == 5)
{
    Console.WriteLine("Пятница");
}
else if (numberDayOfWeek == 6)
{
    Console.WriteLine("Суббота");
}
else if (numberDayOfWeek == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Нет такого дня");
}
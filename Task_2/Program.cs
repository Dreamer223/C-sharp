﻿// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

// int number = new Random().Next(100, 1000); // от 10 включительно до 100 НЕ включительно
// Console.WriteLine("Случайное число: " + number);
// int first = number / 100;
// int second = number % 10;
// Console.Write(first);
// Console.Write(second);


// Задача 2. Напишите программу, которая будет принимать 
// на вход два числа и выводить, является ли второе число кратным 
// первому. Если второе число не кратно числу первому, 
// то программа выводит остаток от деления.

Console.Write("Введите число А:");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В:");
double b = Convert.ToInt32(Console.ReadLine());
double del = a % b;
if (del == 0)
{
    Console.Write("B кратное А");
}
else
{
    Console.Write(del);
}


// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// Задача 3. Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// Console.Write("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 7 == 0 && a % 23 == 0)
// {
//     Console.Write("Кратно");
// }
// else
// {
//     Console.Write("Не кратно");
// }
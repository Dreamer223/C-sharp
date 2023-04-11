// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

int number = new Random().Next(100, 1000); // от 10 включительно до 100 НЕ включительно
Console.WriteLine("Случайное число: " + number);
int first = number / 100;
int second = number % 10;
Console.Write(first);
Console.Write(second);
﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами (длина массива 5 элементов). Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] array = new int[5];
// int number = 0;
// void FillArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);

//     }
//     return;
// }
// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write("[" + array[i] + "]");
//     }

// }
// void ChetIndexArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int chet = array[i] % 2;
//         if (chet == 0)
//         {

//             number++;
//             Console.WriteLine("Четное число в массиве: (" + array[i]+")");
//         }
//     }
//     Console.WriteLine(number);
//     return;
// }

// FillArray();
// PrintArray();
// Console.WriteLine();
// ChetIndexArray();

// Задача 36: Задайте одномерный массив, заполненный случайными числами 
// (длина массива 5 элементов). Найдите сумму элементов, стоящих на нечётных 
// индексах (индексы с нуля).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] array = new int[5];
// int number = 0;
// void FillArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 100);

//     }
//     return;
// }
// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write("[" + array[i] + "]");
//     }
//     return;

// }

// void SummNechetIndexNumber()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i % 2 == 1)
//         {
//             number = number + array[i];
//         }
//     }
//     Console.Write(number);
//     return;
// }
// FillArray();
// PrintArray();
// Console.WriteLine();
// SummNechetIndexNumber();

// Задача 38: Задайте массив вещественных чисел от -100 до 100 
// (длина массива 5 элементов). Найдите разницу между максимальным и 
// минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Console.WriteLine("Введите длинну массива: ");
// int[] array = new int[int.Parse(Console.ReadLine())];
// int max = 0;
// int min = 0;
// void FillArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 101);

//     }
//     return;
// }
// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write("[" + array[i] + "]");
//     }
//     return;

// }

// void MaxElements()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//     }
// }

// void MinElements()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
// }

// void Difference()
// {
//     int difference = max - min;
//     Console.WriteLine($"Разница между максимальным числом {max} и минимальным числом {min} = {difference}");
// }


// FillArray();
// PrintArray();
// Console.WriteLine();
// MaxElements();
// MinElements();
// Difference();



// Доп. задачи
// Задача 3: Задайте массив из 8 случайных чисел из промежутка [-9, 9]. 
// Напишите программу получает на вход число и определяет, присутствует ли 
// заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да


// Console.WriteLine("Введите длинну массива: ");
// int[] array = new int[int.Parse(Console.ReadLine())];
// void FillArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 9);

//     }
//     return;
// }
// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write("[" + array[i] + "]");
//     }
//     return;

// }
// Console.WriteLine("Введите ваше число");
// int b = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == b)
//     {
//         b = array[i];
//         Console.WriteLine($"Есть соответствие с вашим числом {b}");
//         break;
//     }
//     // else
//     // {
//     // Console.WriteLine("Не нашлось соответсвующего элемента с вамши числом в этом массиве");
//     // break;
//     // }
// }
// // Console.WriteLine("Не нашлось соответсвующего элемента с вамши числом в этом массиве");


// FillArray();

// PrintArray();

// //  НЕ ПОНИМАЮ КАК СДЕЛАТЬ ВРОДЕ ВСЕ ПРАВИЛЬНО, НО ВСЕ РАВНО НЕ ПРАВИЛЬНО //
// // Elemunts();

// Задача 4: Задайте массив из 10 случайных чисел из промежутка [-100, 100]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2] -> 0

// [10, 11, 12, 13, 14] -> 5
int[] array = new int[int.Parse(Console.ReadLine())];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);

}
for (int i = 0; i < array.Length; i++)
{
    Console.Write("[" + array[i] + "]");
}
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] >= 10 && array[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine($"В в этом массиве в промежутке от 10 до 99 {count} чисел");
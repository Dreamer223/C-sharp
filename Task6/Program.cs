// Задача 1. Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

// int[] array = new int[5];
// void FillArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 10);
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
// void Perevertish()
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//         // Console.Write(array[i]);
//     } 
// }

// void PrintPerevertish()
// {
//      for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//     }
// }
// FillArray();
// PrintArray();
// Console.WriteLine();
// Perevertish();
// PrintPerevertish();


// Задача 2. Вычислить среднее арифметическое положительных элементов в 
// одномерном массиве. Элементы одномерного массива задаются случано и лежат в 
// промежутке от -10 до 10

// [1, -5, 8, 4, -9] -> 4.33

// int[] array = new int[5];
// void FillArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 10);
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
// FillArray();
// PrintArray();

// double arifmeticheskaya = 0;
// double count = 0;
// for (int i = 0; i < array.Length; i++)
// {
    
//     if (array[i] > 0)
//     {
//         // int arifmeticheskaya = 0;
//         arifmeticheskaya = arifmeticheskaya + array[i];
//         count++;
//     }
//     
// }
// arifmeticheskaya = arifmeticheskaya / count;
// Console.Write(arifmeticheskaya);



// Задча 3. Задайте двумерный массив со случайными числами от -10 до 10. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.)

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12
// int[,] arr = new int[5, 4];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(0, 11);
//     }
// }

// void PrintArray(int[,] array) // Метод позволяет вывести массив в консоль
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++) 
//     {
//         Console.Write($"{array[i, j]} ");
//     }
// Console.WriteLine();
// }
// }

// int summ = 0; // переменная хранит в себе сумму чисел главной диагонали 
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         if (j == i)
//         {
//            summ +=   arr[i, j];
//         }

//     }
// }


// PrintArray(arr);
// Console.WriteLine();
// Console.WriteLine($"Сумма чисел главной диагонали  = {summ}");
﻿// string[,] table = new string[2, 5];


// table[1, 2] = "Слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }
// void PrintArray(int[,] matr)
// {

// for(int i = 0; i < matr.GetLength(0) ; i++) // GetLength(0) - это строки матрицы
// {
//     for(int j = 0; j < matr.GetLength(1); j++) // GetLength(1) - это столбцы матрицы
//     {
//         Console.Write($"{matr[i, j]} ");
//     }
//     Console.WriteLine();
// }

// }
// void FillArray(int[,] matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1, 10);
//         }
//     }
// }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


//!!!!!!   ВНИМАНИЕ  !!!!!
// РЕКУРСИЯ
// uint Factorial(uint n)
// {
//     if (n == 1) return 1;
//     else return n* Factorial(n -1);
// }
// for (uint i = 1; i < 40; i++)
// {
//    Console.WriteLine($"{i}! + {Factorial(i)}"); 
// }


// double Fibanacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibanacci(n - 1) + Fibanacci(n - 2);
// }

// for (int i = 1; i < 60; i++)
// {
//     Console.WriteLine($"f({i})= {Fibanacci(i)}");

// }


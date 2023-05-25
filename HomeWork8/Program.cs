using System.Linq;

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int n = 3;
// int m = 4;

// int[,] arrSort = new int[n, m];
// void FillArray()
// {
//     for (int i = 0; i < arrSort.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrSort.GetLength(1); j++)
//         {
//             arrSort[i, j] = new Random().Next(0, 10);
//         }

//     }

// }

// void PrintArray()
// {
//     for (int i = 0; i < arrSort.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrSort.GetLength(1); j++)
//         {
//             System.Console.Write("[" + arrSort[i, j] + "]" + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[] TempArray = new int[m * n];
// void PrintArray1()
// {
//     for (int i = 0; i < TempArray.Length; i++)
//     {
//         System.Console.Write($"[{TempArray[i]}] ");
//     }
// }

// FillArray();
// PrintArray();
// System.Console.WriteLine();
// int index = 0;

// for (int i = 0; i < arrSort.GetLength(0); i++)
// {
//     for (int j = 0; j < arrSort.GetLength(1); j++)
//     {
//         TempArray[index] = arrSort[i, j];
//         index++;
//     }
// }

// PrintArray1();
// System.Console.WriteLine();
// Array.Sort(TempArray);
// Array.Reverse(TempArray);
// PrintArray1();
// index = 0;
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         arrSort[i, j] = TempArray[index];
//         index++;
//     }
// }
// System.Console.WriteLine();
// PrintArray();

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка
// int rows = 4;
// int colums = 4;

// int[,] arrSort = new int[rows, colums];
// void FillArray()
// {
//     for (int i = 0; i < arrSort.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrSort.GetLength(1); j++)
//         {
//             arrSort[i, j] = new Random().Next(0, 10);
//         }

//     }

// }

// void PrintArray()
// {
//     for (int i = 0; i < arrSort.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrSort.GetLength(1); j++)
//         {
//             System.Console.Write("[" + arrSort[i, j] + "]" + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// FillArray();
// PrintArray();
// int summ = 0;
// int temp = int.MaxValue;
// int minSummImdexRows = -1;
// for (int i = 0; i < arrSort.GetLength(0); i++)
// {
//     for (int j = 0; j < arrSort.GetLength(1); j++)
//     {
//         summ += arrSort[i, j];
//     }
//     if (summ < temp)
//     {
//         temp = summ;
//         minSummImdexRows = i;
//     }
//     summ = 0;
// }
// System.Console.WriteLine("Min summ rows " + temp);
// System.Console.WriteLine($"Rows: {minSummImdexRows + 1}");


// Задача 58: Задайте два двумерных массива (от 0 до 10). 
// Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

// int rows = 4;
// int colums = 4;

// int[,] One = new int[rows, colums];
// int[,] Two = new int[rows, colums];
// int[,] Array = new int[rows, colums];
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             System.Console.Write("[" + array[i, j] + "]" + " ");
//         }
//         System.Console.WriteLine();
//     }
// }



// FillArray(One);
// FillArray(Two);
// PrintArray(One);
// System.Console.WriteLine();
// PrintArray(Two);
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < colums; j++)
//     {
//         Array[i,j]=One[i,j]*Two[i,j];
//     }
// }
// System.Console.WriteLine();
// PrintArray(Array);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// int[,,] array = new int[2, 2, 2];
// Random random = new Random();
// HashSet<int> generatedNumbers = new HashSet<int>();

// int xSize = array.GetLength(0);
// int ySize = array.GetLength(1);
// int zSize = array.GetLength(2);

// for (int i = 0; i < xSize; i++)
// {
//     for (int j = 0; j < ySize; j++)
//     {
//         for (int k = 0; k < zSize; k++)
//         {
//             int randomNumber;
//             do
//             {
//                 randomNumber = random.Next(10, 100);
//             } while (generatedNumbers.Contains(randomNumber));

//             array[i, j, k] = randomNumber;
//             generatedNumbers.Add(randomNumber);
//         }
//     }
// }

// for (int i = 0; i < xSize; i++)
// {
//     for (int j = 0; j < ySize; j++)
//     {
//         for (int k = 0; k < zSize; k++)
//         {
//             System.Console.Write(array[i, j, k] + " ");
//             Console.WriteLine($"Элемент[{i}, {j}, {k}]: {array[i, j, k]}");
//         }

//     }
//     System.Console.WriteLine();
// }




// Доп.Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 5; 
int[,] arr = new int[n, n]; 

int value = 1; 
int row = 0; 
int col = 0; 

while (value <= n * n) 
{
    
    for (int i = col; i < n - col; i++)
    {
        arr[row, i] = value;
        value++;
    }

   
    for (int i = row + 1; i < n - row; i++)
    {
        arr[i, n - col - 1] = value;
        value++;
    }

    
    for (int i = n - col - 2; i >= col; i--)
    {
        arr[n - row - 1, i] = value;
        value++;
    }

    
    for (int i = n - row - 2; i > row; i--)
    {
        arr[i, col] = value;
        value++;
    }

    
    row++;
    col++;
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
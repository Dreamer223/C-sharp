// Задача 1: Задайте двумерный массив случайных чисел от 0 до 10. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4

// 5 9 2 3

// 1 4 7 2


// int[,] arrRevers = new int[3, 4];
// void FillArray()
// {
//     for (int i = 0; i < arrRevers.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrRevers.GetLength(1); j++)
//         {
//             arrRevers[i, j] = new Random().Next(0, 10);
//         }

//     }

// }

// void PrintArray()
// {
//     for (int i = 0; i < arrRevers.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrRevers.GetLength(1); j++)
//         {
//             System.Console.Write("[" + arrRevers[i, j] + "]" + " ");
//         }
//         System.Console.WriteLine();
//     }
// }


// FillArray();
// PrintArray();


// for (int i = 0; i < arrRevers.GetLength(0); i++)
// {
//     for (int j = 0; j < arrRevers.GetLength(1); j++)
//     {
//         if (i == 0)
//         {
//             int temp = arrRevers[ arrRevers.GetLength(0) - 1,j];
//             arrRevers[ arrRevers.GetLength(0) - 1,j] = arrRevers[i, j];
//             arrRevers[i, j] = temp;
//         }
//     }

// }
// System.Console.WriteLine();
// PrintArray();

// Задача 2: Из двумерного массива случайных целых чисел от 0 до 10 удалить строку 
// и столбец, на пересечении которых расположен наименьший элемент.

FillArray();
PrintArray();
System.Console.WriteLine();
int temp;
for (int i = 0; i < arrRevers.GetLength(0); i++)
{
    for (int j = 0; j < arrRevers.GetLength(1); j++)
    {
        temp = arrRevers[0, 0];
        if (arrRevers[i, j] <= temp)
        {
            temp = arrRevers[i, j];
            int xCoord = -1;
            int yCoord = -1;

            for (int i = 0; i < arrRevers.GetLength(0); i++)
            {
                for (int j = 0; j < arrRevers.GetLength(1); j++)
                {
                    if (arrRevers[i, j] == temp)
                    {
                        xCoord = i;
                        yCoord = j;
                        break;
                    }
                }
                if (xCoord != -1 && yCoord != -1)
                {
                    break;
                }
            }

            if (xCoord == -1 || yCoord == -1)
            {
                Console.WriteLine("Элемент не найден");
            }
            else
            {
                Console.WriteLine("Координаты элемента: ({0}, {1})", xCoord, yCoord);
            }
        }
    }
}

int xCoord = -1;
int yCoord = -1;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (arrRevers[i, j] == temp)
        {
            xCoord = i;
            yCoord = j;
            break;
        }
    }
    if (xCoord != -1 && yCoord != -1)
    {
        break;
    }
}

if (xCoord == -1 || yCoord == -1)
{
    Console.WriteLine("Элемент не найден");
}
else
{
    Console.WriteLine("Координаты элемента: ({0}, {1})", xCoord, yCoord);
}

// for (int i = 0; i < arrRevers.GetLength(0); i++)
// {
//     for (int j = 0; j < arrRevers.GetLength(1); j++)
//     {
//         if (arrRevers[i, j] == temp)
//         {

//         }
//         else
//         {
//             column++;
//             row++;
//         }

//     }
// }

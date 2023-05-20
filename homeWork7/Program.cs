// 1 задача домашки

// int m = 3; 
// int n = 4; 
// double min = 1.0;
// double max = 10.0;

// double[,] array = new double[m, n]; 

// Random random = new Random(); 

// for (int i = 0; i < m; i++)
// {

//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = random.NextDouble() * (max - min) + min;
//     }
// }


// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(array[i, j].ToString("F2") + " ");
//     }
//     Console.WriteLine();
// }
// Console.ReadKey();



// 2 задача домашки


// int[,] array = new int[,] 
// {
//      { 1, 4, 7, 2 }, 
//      { 5, 9, 2, 3 }, 
//      { 8, 4, 2, 4 } 
// };
// Console.Write("Введите номер строки: ");
// int row = int.Parse(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int column = int.Parse(Console.ReadLine());
// if (row >= array.GetLength(0) || column >= array.GetLength(1))
// {
//     Console.WriteLine("Такого элемента нет в массиве.");
// }
// else
// {
//     Console.WriteLine($"Значение элемента: {array[row, column]}");
// }


// 3 Задача домашки


// int[,] array = new int[,] 
// { 
//     { 1, 4, 7, 2 },
//     { 5, 9, 2, 3 }, 
//     { 8, 4, 2, 4 } 
// };
// int rows = array.GetLength(0);
// int cols = array.GetLength(1);

// for (int j = 0; j < cols; j++)
// {
//     double sum = 0;
//     for (int i = 0; i < rows; i++)
//     {
//         sum += array[i, j];
//     }
//     double average = Math.Round(sum / rows, 2);
//     Console.WriteLine($"Средние значание столбца {j+1}: {average}");
// }
// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.Write("Сколько чисел вы хотите ввести? ");
// int m = int.Parse(Console.ReadLine());

// int count = 0;
// for (int i = 0; i < m; i++)
// {
//     Console.Write("Введите число: ");
//     int num = int.Parse(Console.ReadLine());
//     if (num > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine("Количество чисел, больших 0: " + count);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Формулы нахождения координат x и y точки пересечения:
// x = (b2-b1)/(k1-k2);
// y = k1*x+b1;

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите значение k1: ");
// double k1 = double.Parse(Console.ReadLine());

// Console.Write("Введите значение b1: ");
// double b1 = double.Parse(Console.ReadLine());

// Console.Write("Введите значение k2: ");
// double k2 = double.Parse(Console.ReadLine());

// Console.Write("Введите значение b2: ");
// double b2 = double.Parse(Console.ReadLine());

// if (k1 == k2)
// {
//     Console.WriteLine("Прямые параллельны, нет точки пересечения.");
// }
// else
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * x + b1;
//     Console.WriteLine("Точка пересечения: (" + x + ", " + y + ")");
// }
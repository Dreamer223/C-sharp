
//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// double pow = Math.Pow(a, b);
// Console.Write(pow);
// double GetDegree(int number1, int number2)
// {
//     Console.Write ("Ввведите число: ");
//     double a = Convert.ToDouble(Console.ReadLine());
//     Console.Write ("Ввведите степень: ");
//     double b = Convert.ToDouble(Console.ReadLine());
//     double pow = Math.Pow(a, b);
//     return pow;
// }
// double Pow = GetDegree(1, 1); // Вопрос почему если убрать со скобок числа выдает ошибку, а если ставить разные числа то все нормально?
// Console.Write(Pow);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// int Sum_number( int number)
// {
//      Console.Write("Введите число: ");
//         int number1 = int.Parse(Console.ReadLine());

//         int sum = 0;
//         while (number1 > 0) 
//         {
//             sum = sum + number1 % 10;
//             number1 = number1 / 10;
//         }

//         Console.WriteLine("Сумма цифр: " + sum);
//     return sum;
// }
    

// Sum_number(1);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов (от -10 до 10) и выводит их на экран.

// 1, 2, 5, 7, 9 -> [1, 2, 5, 7, 9]

// 6, 1, 3 -> [6, 1, 3]

// void FillArray(int[] array)
// {
//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = new Random().Next(-10, 11);
//         Console.Write(array[index] + " ");
        
//     }
//     Console.Write("->");
// }
// void PrintArray(int[] array)
// {
//     for (int index = 0; index < array.Length; index++)
//     {
//         Console.Write("[" + array[index] + "]");
//     }
// }


// int[] array_1 = new int[8];

// FillArray(array_1);
// PrintArray(array_1);
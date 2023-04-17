// // Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом. 
// (палиндром - число читается слева направо и справа налево одинаково)

// // 14212 -> нет

// // 12821 -> да

// // 23432 -> да

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());


// string num_str = num.ToString();
// bool is_palindrome = true;

// for (int i = 0; i < num_str.Length / 2; i++) 
// { // перебираем половину цифр числа
//     if (num_str[i] != num_str[num_str.Length - 1 - i]) 
//     {
//         is_palindrome = false;
//         break;
//     }
// }

// if (is_palindrome) 
// {
// Console.WriteLine("Число {0} является палиндромом", num);
// } 
// else 
// {
//     Console.WriteLine("Число {0} не является палиндромом", num);
// }


// // Задача 21

// // Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// // A (3,6,8); B (2,1,-7), -> 15.84

// // A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату Х:");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y:");
// double y = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z:");
// double z = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Х1:");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y1:");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z1:");
// double z1 = Convert.ToDouble(Console.ReadLine());
// double AB = Math.Sqrt(Math.Pow(x1-x, 2)+Math.Pow(y1-y, 2)+Math.Pow(z1-z, 2));
// Console.Write(AB);





// // Задача 23

// // Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.

// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125
// Console.Write("Введите число:");
// double x = Convert.ToDouble(Console.ReadLine());
// double i = 1;
// Console.Write("Квадраты от числа 1 до {0}:", x);
// while (i <= x)
// {
//     double square = Math.Pow(i, 3);
//     Console.WriteLine(square);
//     i++;
    

// }
// Задача 1.
// Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти 
// плоскости, в которой находится эта точка и показывает диапазон 
// возможных координат точек в этой четверти (x и y).
// A (2, 3) -> 1 четверть, x > 0, y > 0
// A (-5, -8) -> 3 четверть, x < 0, y < 0

// Console.Write("Введите координату Х:");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату У:");
// double y = Convert.ToDouble(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Координата Х:" +x);
//     Console.WriteLine("Координата Y:" +y);
//     Console.WriteLine("Эта точка находится на 1 четверти и в ней могут быть координаты больше 0 Х и У");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine("Координата Х:" +x);
//     Console.WriteLine("Координата Y:" +y);
//     Console.WriteLine("Эта точка находится на 3 четверти и в ней могут быть координаты меньше 0 Х и У");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine("Координата Х:" +x);
//     Console.WriteLine("Координата Y:" +y);
//     Console.WriteLine("Эта точка находится на 4 четверти и в ней могут быть координаты Х больше 0 и У меньше 0");
// }
// if (x < 0 && y > 0)
// {
//     Console.WriteLine("Координата Х:" +x);
//     Console.WriteLine("Координата Y:" +y);
//     Console.WriteLine("Эта точка находится на 2 четверти и в ней могут быть координаты X меньше 0 и У больше 0");
// }

// Задача 2.
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите координату Х:");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату У:");
// double y = Convert.ToDouble(Console.ReadLine());
// double x1 = (y-x);
// double y1 = (y-x);
// if (x1 < 0)
// {
//     double v = x1 * -1;
// }
// if(y1 < 0)
// {
//     double v1 = y1 * -1;
// }
// double Pif1 = Math.Pow(x1, 2);
// double Pif2 = Math.Pow(y1, 2);
// double Pif3 = Pif1 + Pif2;
// double Pif = Math.Sqrt(Pif3);
// Console.Write(Pif);




// Задача 3. Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Write("Введите число:");
double x = Convert.ToDouble(Console.ReadLine());
double i = 1;
Console.Write("Квадраты от числа 1 до {0}:", x);
while (i <= x)
{
    double square = Math.Pow(i, 2);
    Console.WriteLine(square);
    i++;
    

}

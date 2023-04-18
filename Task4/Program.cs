// Задача 1:
// Напишите программу, которая принимает на вход число N и выдаёт 
// сумму чисел от 1 до N.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int GetSum(int number)
// {
//     int i = 1;
//     int sum = ((i + number)*number)/2;  
//     return sum;
// }
// int SumNumbers = GetSum(10);
// Console.Write(SumNumbers);

// Задача 2:
// Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120

// int getFactorial (int number)
// {
//     int factorial = 1;
//     // int count = 1;
//     for (int count = 1; count <= number; count++)
//     {
//         factorial *= count;
//         // count++;
//     }
//     return factorial;
// }

// int number = Convert.ToInt32 (Console.ReadLine ());
// Console.WriteLine (getFactorial (number));

// Задача 3 (общая):
// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(0, 2); // 0 и 1
        Console.Write(array[index] + " ");
    }
}

// void PrintArray(int[] array)
// {
    
//     for (int index = 0; index < array.Length; index++)
//     {
//         Console.Write(array[index] + " ");
//     }
// }


int[] array_1 = new int[8];

FillArray(array_1);
// PrintArray(array_1);

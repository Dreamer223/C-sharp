// // Задача 1: Задайте массив из 10 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите суммы отрицательных и 
// положительных элементов массива.

int[] array = new int[10];
 
for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(-9, 10);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
}
int sum = 0;
int div = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        
        sum = array[i] + sum;
    }
    else
    {
        
        div = div + array[i];
    }
    
}
Console.WriteLine("Сумма положительных = " + sum + "  Cумма отрицательных = " + div);

// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных
//  чисел равна 29, сумма отрицательных равна -20.

// // Задача 2: Задайте массив из 10 элементов из промежутка [-9, 9] и 
// положительные элементы замените на соответствующие отрицательные, и 
// наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// int[] array = new int[10];
 
// for (int i = 0; i < array.Length; i++)
// {
//     int randomNumber = new Random().Next(-9, 10);
//     array[i] = randomNumber;
//     Console.Write(array[i] + " ");
// }

// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] < 0)
//     array[i] = array[i] * -1;
//     else
// {
//     array[i] = array[i] * -1;
// }
// Console.Write("[" + array[i] + "]");
// }


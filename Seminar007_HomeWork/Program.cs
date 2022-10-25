/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

// double[,] array = new double[3, 4];
// void NewArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }
// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// NewArray(array);
// PrintArray(array);


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

// Console.WriteLine("Введите размер строки массива: ");
// int numRows = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.WriteLine("Введите размер столбца массива: ");
// int numColums = Convert.ToInt32(Console.ReadLine()) - 1;
// int[,] array = new int[6, 7];
// Console.Write("Наш массив: ");
// Console.WriteLine();
// void NewArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// NewArray(array);
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// PrintArray(array);
// if (numRows < 0 | numRows > array.GetLength(0) - 1 | numColums < 0 | numColums > array.GetLength(1) - 1)
// {
//     Console.WriteLine("Такого элемента в массиве нет");
// }
// else Console.WriteLine($"Значение эллемента равняется: {array[numRows, numColums]}");


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Введите количество строк массива");
int numRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int numColums = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int[,] array = new int[numRows, numColums];
double[] mdArray = new double[array.GetLength(1)];

void NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
NewArray(array);
Console.WriteLine("Наш массив: ");
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
PrintArray(array);

void MiddleSum(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result += array[j, i];
        }
        mdArray[i] = result / array.GetLength(0);
    }
}
MiddleSum(array);

void MiddleSumArray(double[] array)
{
    for (int i = 0; i < mdArray.Length; i++)
    {
        Console.Write($"{Math.Round(mdArray[i], 2)} ");
    }
    Console.WriteLine();
}
MiddleSumArray(mdArray);
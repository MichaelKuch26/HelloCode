// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.Clear();
// int [,] ar = new int[3,4];
// void NewArray(int[,] ar)
// {
//     for (int i = 0; i < ar.GetLength(0); i++)
//     {
//         for (int j = 0; j < ar.GetLength(1); j++)
//         {
//             ar[i,j] = new Random().Next(-100,101);
//         }
//     }
// }
// void PrintArray(int[,] ar)
// {
//     for (int i = 0; i < ar.GetLength(0); i++)
//     {
//         for (int j = 0; j < ar.GetLength(1); j++)
//         {
//             Console.Write($"{ar[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// NewArray(ar);
// PrintArray(ar);

// Задача 48: Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.Write("Введите размер m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = i + j;
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// Console.WriteLine("Введите m");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите n");
// int numN = Convert.ToInt32(Console.ReadLine());
// Console.Clear();
// int [,] array = new int [numM,numN];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//        array[i,j] = new Random().Next(0,10);
//     }
// }
// printArray(array);
// void printArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// stepen(array);
// void stepen(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            if (i % 2 == 0 && j % 2 == 0)
//            {
//             array[i,j] = array[i,j] * array[i,j];
//            }
//            Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.WriteLine("Введите m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите n");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Clear();
// int [,] array = new int [m,n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//        array[i,j] = new Random().Next(0,10);
//     }
// }
// printArray(array);
// void printArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int sum = 0;
// summa(sum);
// void summa(int sum)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            if (i == j)
//            {
//             sum = sum + array[i,j];
//            }
//         }
//     }
//     Console.Write("Сумма равна: " + sum);
// }
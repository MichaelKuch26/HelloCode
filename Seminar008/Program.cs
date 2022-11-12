/*Задача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.*/

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] Fill2DArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void SortArray(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int temp = array[rows - 1, j];
//         array[rows - 1, j] = array[0, j];
//         array[0, j] = temp;
//     }
// }

// int[,] array1 = Fill2DArray(3, 4);
// Print2DArray(array1);
// Console.WriteLine();
// SortArray(array1);
// Print2DArray(array1);

/*Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.*/

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] Fill2DArray()
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
//     }
//     return array;
// }
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] SortArray(int[,] array)
// {
//     int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             newArray[i, j] = array[j, i];
//         }
//     }

//     return newArray;
// }

// if (rows == columns)
// {
//     int[,] massiv = Fill2DArray();
//     Print2DArray(massiv);
//     Console.WriteLine();
//     int[,] massiv1 = SortArray(massiv);
//     Print2DArray(massiv1);
// }
// else
// {
//     Console.WriteLine("Для данной сортировки массив должен быть квадратным");
// }

/*Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза*/

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] Fill2DArray()
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 21);
//         }
//     }
//     return array;
// }
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }
// void Dictionary(int[,] array)
// {
//     int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
//     foreach (int num in numbers)
//     {
//         int count = 0;
//         foreach (int i in array)
//         {
//             if (num == i)
//             {
//                 count++;
//             }
//         }
//         if (count > 0)
//         {
//             Console.WriteLine($"Значение {num} встречается {count} раз");
//         }
//     }

// }

// int[,] massiv = Fill2DArray();
// Print2DArray(massiv);
// Dictionary(massiv);

/*Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец,
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7*/

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] Fill2DArray()
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 33);
        }
    }
    return array;
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void DelRowsColumns(int[,] array)
{
    int min = array[0, 0];
    int minRows = 0;
    int minColumns = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minRows = i;
                minColumns = j;
            }
        }
    }
    System.Console.WriteLine($"минимальное значение = {min}");
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    int m = 0;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        if (k == minRows) k += 1;

        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = array[k, j];
            Console.Write($"{newArray[i, j]}\t");
        }
        System.Console.WriteLine();
        k++;
    }
}

int[,] massiv = Fill2DArray();
Print2DArray(massiv);
DelRowsColumns(massiv);


/*Задача 61: Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника*/
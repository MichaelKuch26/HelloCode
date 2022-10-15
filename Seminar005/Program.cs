// string s1 = "c#";
// string s2 = "Python";
// string s3 = s1 + " - " + s2;
// string s4 = string.Concat(s1, s2, s3);
// string s5 = "Java";
// string s6 = "C++";
// string s7 = "JS";
// Console.WriteLine(s3);
// Console.WriteLine(s4);

// Console.WriteLine(s2.Length);
// Console.WriteLine(s2[1]);

// string[] arrayS = new string[] {s1, s2, s5, s6, s7};
// string s10 = string.Join(" ", arrayS);
// Console.WriteLine(s10);


/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
 сумма отрицательных равна -20.*/

// Console.Clear();
// int sum = 0;
// int minus = 0;
// int[] array = new int[12];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//         Console.Write(array[i] + " ");
//         if(array[i] > 0) sum = sum + array[i];
//         if (array[i] < 0) minus = minus + array[i];
//     }

// Console.WriteLine("Сумма положит чисел: " + sum);
// Console.WriteLine("Сумма отрицат чисел: " + minus); 


/*Задача 32: Напишите программу замена элементов массива: положительные элементы 
 замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

// Console.Clear();
// int[] array = new int[4];
// int ab1 = 0;
// int ab2 = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-99, 100);
//         Console.Write(array[i] + " ");
//     }
//     for (int i = 0; i < array.Length; i++)
//     { 
//         if(array[i] > 0)
//         {
//             ab1 = array[i] * -1;
//             Console.WriteLine(ab1 + " ");
//         }
//         if (array[i] < 0)
//         {
//             ab2 = array[i] * -1;
//             Console.WriteLine(ab2 + " ");        
//         }
//     }
    
    

/*Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

// void printArray(int[] arr)
// {
//     Console.Write($"[{arr[0]}");
//     for (int i = 1; i < arr.Length; i++)
//         Console.Write($", {arr[i]}");
//     Console.WriteLine($"]");
// }
// Random r = new Random();
// // int len = 12;
// int count = 0;
// int num = 3;

// // int[] arr = getArray(len);
// int[] arr = { 6, 7, 19, 345, 3 };
// printArray(arr);

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] == num)
//         count++;
// }
// Console.WriteLine(count > 0 ? "да" : "нет");

/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество 
элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

// Random r = new Random();
// int len = 123;
// int count = 0;

// int[] arr = getArray(len);
// printArray(arr);

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] >= 10 && arr[i] <= 99)
//         count++;
// }
// Console.WriteLine(count);


// int[] getArray(int len)
// {
//     int[] arr = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = r.Next(1, 999);
//     }
//     return arr;
// }

// void printArray(int[] arr)
// {
//     Console.Write($"[{arr[0]}");
//     for (int i = 1; i < arr.Length; i++)
//         Console.Write($", {arr[i]}");
//     Console.WriteLine($"]");
// }

/*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/
 

Random r = new Random();
int len = 5;
int len_sum = len / 2 + len % 2;
int[] sum = new int[len_sum];

int[] arr =  getArray(len);

for (int i = 0; i < len_sum; i++)
{
    // Console.WriteLine($"{}");
    if (i == len - i)
        sum[i] = arr[i];
    else
        sum[i] = arr[i] * arr[len - 1 - i];

}
int[] getArray(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = r.Next(1, 9);
    }
    return arr;
}
void printArray(int[] arr)
{
    Console.Write($"[{arr[0]}");
    for (int i = 1; i < arr.Length; i++) Console.Write($", {arr[i]}");
    Console.WriteLine($"]");
}
printArray(arr);

// Console.WriteLine(count);
printArray(sum);
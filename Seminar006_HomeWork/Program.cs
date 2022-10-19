/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
Console.Clear();
Console.WriteLine("Введите количество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int result = 0;
int max = 0;
Console.WriteLine("Наш массив чисел: ");
RandomArray(array);
PrintArray(array);
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > 0)
    {
        result++;
    }
}
System.Console.WriteLine();
Console.WriteLine("Положительных элементов получилось: " + result);
void RandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-999, 1000);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Clear();
Console.WriteLine("Введите значение k1: ");
double numK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double numK2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1: ");
double numB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double numB2 = Convert.ToInt32(Console.ReadLine());
double x = 0;
double y = 0;
if (numB1 != numB2 || numK1 != numK2)
{
    x = (-numB2 + numB1)/(-numK1 + numK2);
    y = numK2 * x + numB2;
    Console.WriteLine("$Точка пересечения двух прямых имеет координаты: (" + x + "; " + y + " )");
}
else Console.WriteLine("$Точек пересечения двух прямых нет, они параллельны");



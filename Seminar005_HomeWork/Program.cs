/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Clear();
System.Console.WriteLine("Введите длину массива: ");
int massiv = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[massiv];
System.Console.WriteLine("Наш массив: ");
NewArrayRandom(Array);
PrintArray(Array);
int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    if(Array[i]%2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine("Количество четных чисел в массиве равняется: " + count);
void NewArrayRandom(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] Array)
{
    System.Console.Write("[");
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write(Array[i] + " ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
Console.WriteLine("Введите длину массива: ");
int massiv = Convert.ToInt32(Console.ReadLine());
int[] myarray = new int[massiv];
int sum = 0;
Console.WriteLine("Наш массив: ");
NewRandomMas(myarray);
PrintArray(myarray);
for (int j = 1; j < myarray.Length; j+=2) sum = sum + myarray[j];
Console.WriteLine("Сумма чисел на нечетных позициях равняется: " + sum);
void NewRandomMas (int[] myarray)
{
    for (int i = 0; i < myarray.Length; i++) myarray[i] = new Random().Next(-99, 100);
} 
void PrintArray (int[] myarray)
{
    Console.Write("[");
    for (int i = 0; i < myarray.Length; i++) Console.Write(myarray[i] + " ");
    Console.Write("]");
}


/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.Clear();
Console.Write("Задайте длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double min = 0;
double max = 0;
double result = 0;
double[] arrayX = new double[size];
Console.Write("Наш массив: ");
NewRandomArray(arrayX);
PrintNewArray(arrayX);
for (int i = 0; i < arrayX.Length; i++)
{
    if(min > arrayX[i]) min = arrayX[i];
    if(max < arrayX[i]) max = arrayX[i];
    result = max - min;
}
System.Console.WriteLine("Разница между максимальным и минимальным значением равна: " + result);
void NewRandomArray(double[] arrayX)
{
    for (int i = 0; i < arrayX.Length; i++)
    {
        arrayX[i] =  Convert.ToDouble(new Random().Next(-99, 100));
    }
}
void PrintNewArray(double[] arrayX)
{
    Console.Write("[");
    for (int i = 0; i < arrayX.Length; i++) Console.Write(arrayX[i] + " ");
    Console.Write("]");
}
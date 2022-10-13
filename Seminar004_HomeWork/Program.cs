// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Console.Clear();
// Console.WriteLine("Введите число A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// void Stepen(int numA, int numB)
// {
//     for(int i = 1; i <= numB; i++)
//     {
//         result = numA * result;
//         Console.WriteLine($"{numA} в степени {numB} = {result}");
//     }
//     if (numB == 0) Console.WriteLine($"{numA} в степени {numB} = 1");
// }
// Stepen(numA, numB);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
void MyMethod (int number)
{
int result = 0; 
while(number > 0)
{
    result = result + number % 10;
    number = number / 10; 
    
}
Console.Write(result);
}
MyMethod(number);





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Console.Clear();
// int[] Array = new int[8];

// for (int i = 0; i < Array.Length; i++)
// {
//     Array[i] = new Random().Next(0,100);
//     Console.Write(Array[i] + " ");
// }
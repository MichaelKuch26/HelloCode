// string name1 = "Bob";
// string name2 = "Anna";
// string name3 = "Liz";
// string name4 = "John";

// string[] names = {"Bob", name2, name3, "John"};
// Console.WriteLine(names[1]);
// int[] age = {1, 2, 3, 4, 5};
// Console.WriteLine(names[1]);

// Console.WriteLine(age[1]);
// age[1] = age[1] + 6;
// Console.WriteLine(age[1]);

// Console.WriteLine(names.Length);

// for(int i=0; i < names.Length; i++)
// {
//     Console.WriteLine(names[i]);
// }



// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Clear();
// Console.WriteLine("Введите координаты X: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты Y: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if (num > 0)
// {
//     if (num1 > 0) Console.WriteLine("Точка (" + num + " : " + num1 + ") лежит в 1 четверти");
//     else Console.WriteLine("Точка (" + num + " : " + num1 + ") лежит в 4 четверти");
// }
// else
// {
//     if(num1 > 0) Console.WriteLine("Точка (" + num + " : " + num1 + ") лежит во 2 четверти");
//     else Console.WriteLine("Точка (" + num + " : " + num1 + ") лежит в 3 четверти");
// }  


// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Clear();
// Console.WriteLine("Введите номер четверти (1-4): ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1) Console.WriteLine("Диапазон координат от (0:0) до (" + int.MaxValue + "; " + int.MaxValue + ") ");
// if (num == 2) Console.WriteLine("Диапазон координат от (0:0) до (" + -int.MaxValue + "; " + int.MaxValue + ") ");
// if (num == 3) Console.WriteLine("Диапазон координат от (0:0) до (" + -int.MaxValue + "; " + -int.MaxValue + ") ");
// if (num == 4) Console.WriteLine("Диапазон координат от (0:0) до (" + int.MaxValue + "; " + -int.MaxValue + ") ");


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.Clear();
// Console.WriteLine("Введите координаты точки X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
// double result = Math.Round((dist), 2);
// Console.WriteLine($"Расстояние между точками {result}");


// Задача 22: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= num)
{
    Console.Write(i*i + ",");
    i++;
}
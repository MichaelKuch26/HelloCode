// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 10000)
{
    int division1 = number / 10000;
    int remainder1 = number % 10;
 
    if(division1 == remainder1)
        {
            int division2 = (number / 10)% 10;
            int remainder2 = (number / 1000) % 10;
            if(division2 == remainder2) Console.WriteLine("Да");
        }
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Некорректное число!");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//Console.Clear();
// Console.WriteLine("Введите координаты точки X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки Z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки Z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// double result = Math.Round((dist), 2);
// Console.WriteLine($"Расстояние между точками {result}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 1;

// while (i <= num)
// {
//     Console.Write(i*i*i + ", ");
//     i++;
// }
// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет


// Console.Clear();

// Console.WriteLine("Введите число a: ");
// Console.WriteLine("Введите число b: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num * num)
// {
//    Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница


// Console.Clear();
// Console.WriteLine("Введите число дня: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// if (num == 2)
// {
//     Console.WriteLine("Вторник");
// }
// if (num == 3)
// {
//     Console.WriteLine("Среда");
// }
// if (num == 4)
// {
//     Console.WriteLine("Четверг");
// }
// if (num == 5)
// {
//     Console.WriteLine("Пятница");
// }
// if (num == 6)
// {
//     Console.WriteLine("Суббота");
// }
// if (num == 7)
// {
//     Console.WriteLine("Воскресенье");
// }


// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"


// Console.Clear();
// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = 0;
// if (x > 0)
// {
//     y = x * -1;
//     while (y <= x)
//     {
//         Console.WriteLine(y);
//         y = y + 1;
//     }
// }
// else
// {
//     y = x * -1;
//     while (x <= y)
//     {
//         Console.WriteLine(x);
//         x = x + 1;
//     }
// }


// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8


Console.WriteLine("Введите трехзначное число: ");

int num = Convert.ToInt32(Console.ReadLine());

int num1 = num % 10;

Console.WriteLine(num1);
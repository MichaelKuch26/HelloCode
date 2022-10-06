// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num % 100;
int num2 = num1 / 10;
Console.WriteLine(num2);








// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


//Console.Clear();
// Console.WriteLine("Введите число дня недели (1-7): ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num == 1) Console.WriteLine("Нет, день недели является рабочий");
// if (num == 2) Console.WriteLine("Нет, день недели является рабочий");
// if (num == 3) Console.WriteLine("Нет, день недели является рабочий");
// if (num == 4) Console.WriteLine("Нет, день недели является рабочий");
// if (num == 5) Console.WriteLine("Нет, день недели является рабочий");
// if (num == 6) Console.WriteLine("Да, день недели является выходным");
// if (num == 7) Console.WriteLine("Да, день недели является выходным");






// Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 3267912 -> 6


//Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string str = num.ToString();

// if (num > 100 || num == 100)
// {
//     Console.WriteLine($"Третья цифра равна: {str[2]}");
// } 
// else 
// {
//     Console.WriteLine("Третьей цифры нет");
// }
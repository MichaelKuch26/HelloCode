/*Задача 63: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

// Console.WriteLine("Введите натуральное число N: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// int numM = 1;
// Console.WriteLine();

// string NumRec(int numM, int numN)
// {
//     if (numN >= numM) return $"{numM} " + NumRec(numM + 1, numN);
//     else return String.Empty;
// }

// Console.WriteLine(NumRec(numM, numN));


/*Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"*/

// Console.WriteLine("Введите натуральное число M: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите натуральное число N: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// string NatNum(int numM, int numN)
// {
//     if (numM <= numN) return $"{numM} " + NatNum(numM + 1, numN);
//     else return String.Empty;
// }

// Console.WriteLine(NatNum(numM, numN));

// ПРИМЕР ИЗ СЕМИНАРА: ЗАДАЧА С ФАКТОРИАЛОМ

// int fact(int num)
// {
//     if (num == 1) return 1;
//     return num * fact(num - 1);
// }
// int x = fact(5);
// Console.WriteLine($"Факториал {x}");

/*Задача 67: Напишите программу, которая будет принимать на вход 
число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

// Console.WriteLine("Введите натуральное число: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int SumNum(int numN)
// {
//     if (numN == 0) return 0;
//     return numN % 10 + SumNum(numN / 10);
// }
// Console.WriteLine($"Результат: {SumNum(numN)}");

/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

// Console.WriteLine("Введите натуральное число: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите натуральное число: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int PowNum(int numN, int numM)
// {
//     if (numM == 0) return 1;
//     return numN * PowNum(numN, numM - 1);
// }
// Console.WriteLine($"Результат: {PowNum(numN, numM)}");
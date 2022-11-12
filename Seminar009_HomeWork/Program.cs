/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int numM = 1;
Console.WriteLine();

string NumRec(int numM, int numN)
{
    if (numN >= numM) return NumRec(numM + 1, numN) + $" {numM}";
    else return String.Empty;
}

Console.WriteLine(NumRec(numM, numN));

/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15-> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите натуральное число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int SumRec(int numM, int numN)
{
    if (numM >= numN) return 0;
    else return numN + SumRec(numM, numN - 1);

}
Console.WriteLine(SumRec(numM - 1, numN));

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29*/
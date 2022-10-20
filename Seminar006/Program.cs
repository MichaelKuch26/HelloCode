// int [] n = {1, 2, 3, 4, 5};
// int [,] n2 = {{1, 2, 3, 4},
//               {5, 6, 7, 8}};


// for (int i = 0; i < n2.GetLength(0); i++)
// {
//     for (int j = 0; j < n2.GetLength(1); j++)
//     {
//         Console.Write($"{n2[i, j]} ");
//     }
//     Console.WriteLine();
// }

/*Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/
// Console.Clear();
// Console.WriteLine("Введите размер массива: ");
// int l = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[l];
// int temp = 0;
// Console.WriteLine("Исходный массив: ");
// for (int j = 0; j < array.Length; j++)
// {
//     array[j] = new Random().Next(0, 10);
//     Console.Write($"{array[j]} ");
// }

// Console.WriteLine("Развернутый массив: ");
// for (int i = 0; i < array.Length / 2; i++)
// {
//     temp = array[i];
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = temp;
// }

// for (int j = 0; j < array.Length; j++)
// {
//     Console.Write($"{array[j]} ");
// }
// Console.WriteLine();

/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон*/

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) Console.WriteLine("Такой треугольник может быть"); 
// else Console.WriteLine("Такой треугольник не может быть");



/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int remainder;
// string result = string.Empty;
// while (num > 0)
//     {
//         remainder = num % 2;
//         num /= 2;
//         result = remainder.ToString() + result;
//     }
// Console.WriteLine("Binary:  {0}",result);


/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

System.Console.WriteLine("Введите число: ");
int fib = Convert.ToInt32(Console.ReadLine());

int[] fibo = new int[fib];
fibo[0] = 0;
fibo[1] = 1;
for (int i = 2; i < fibo.Length; i++)
{
    fibo[i] = fibo[i-1] + fibo[i-2];
}

for (int j = 0; j < fibo.Length; j++)
{
       System.Console.Write($"{fibo[j]} ");
}

/*Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

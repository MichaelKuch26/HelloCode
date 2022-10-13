// У нас есть график, где даны отрезок 1 -  (х1; x2) и отрезок 2 (х3, x4)
// 	​Необходимо составить код, который находит их пересечение.
// 	Пересечением двух отрезка 1 и 2 могут быть  - отрезок, точка или ничего
// 	С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - границы пересечений отрезков, общую точку или 
//  «не пересекаются».

Console.Clear();
Console.WriteLine("Введите координаты точки 1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
int y3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 4: ");
int x4 = Convert.ToInt32(Console.ReadLine());
int y4 = Convert.ToInt32(Console.ReadLine());
double k1 = (y1 - y2) / (x1 - x2);
double k2 = (y3 - y4) / (x3 - x4);
double b1 = y1 - k1 * x1;
double b2 = y3 - k2 * x3;

if (k1 == k2)
{
   Console.WriteLine("Отрезки параллельны, т.е. не пересекаются");
}
double Xa = (b2 - b1) / (k1 - k2);

if ((Xa < Math.Max(x1, x3)) || (Xa > Math.Min(x2, x4)))
{
    Console.WriteLine($"Отрезки пересекаются в точке {Xa}");
}
else Console.WriteLine();


// МЕТОДЫ

// void SayHello() //не возвращаемая функция с названием "SayHello"
// {
//     Console.WriteLine("Hello C++");
// }
// Console.WriteLine("1");
// SayHello(); //вызов данного метода, это обязательно название самого же метода


// void SayHello(string lang) //не возвращаемая функция с названием "SayHello", но принимает 
// {
//     Console.WriteLine($"Hello {lang}");
// }
// Console.WriteLine("1");
// SayHello("Java"); //вызов данного метода, это обязательно название самого же метода


// int MinMax(int x, int y) // не возвращаемая функция с названием "MinMax",но принимает 
// {
//     if(x > y) 
//     {
//         return x;
//     }
//     else
//     {
//         return y;
//     }
// }
// int max1 = MinMax(5, 3); // возвращаем функцию с аргументами в скобках
// int a1 = 7;
// int a2 = 9;
// int max2 = MinMax(a1, a2); // возвращаем функцию с аргументами в скобках
// Console.WriteLine($"{max1} - {max2} = {max1 - max2}");



// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
// Console.Clear();
// void Sum(int A)
// {
//     int sum=0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum=sum+i;
//     }
//     Console.WriteLine(sum);
// }
// int A=new Random().Next(2,5); // рандомно генерирует число, а не вводим
// Console.WriteLine(A);
// Sum(A);






// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// while (num > 0)
// {
//     num = num / 10;
//     i++;
// }
// Console.WriteLine(i);


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
// void Multi(int N)
// {
//     int mul=1;
//     for (int i = 1; i <= N; i++)
//     {
//         mul=mul*i;
//     }
//     Console.WriteLine(mul);
// }
// int N=new Random().Next(2,5); // также случайно генерируем число
// Console.WriteLine(N);
// Multi(N);

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int [] arrey = new int[8];
// void Print(int[] arrey)
// {
// for (int i = 0; i < arrey.Length; i++)
//     {
//         Console.Write(arrey[i]);
//     }
// }
// void Random(int[] arrey)
// {
// for (int i = 0; i < arrey.Length; i++)
//     {
//         arrey[i] = new Random().Next(0, 2);
//     }
// }
// Random(arrey);
// Print(arrey);


// x1 ^ 5 + x2 ^ 5 + x3 ^ 5 + x4 ^ 5 = x5 ^ 5 от  1 до 300
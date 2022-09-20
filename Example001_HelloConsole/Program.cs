//Знакомство с языками программирования (семинары)
//Урок 1. Знакомство с языком программирования С#
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

// РОМАНОВ АЮ

// Console.WriteLine("Введите число a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
// {
//     Console.WriteLine("max=" + (a));
//     Console.WriteLine("min=" + (b));
// }
// else
// {
//     Console.WriteLine("max=" + (b));
//     Console.WriteLine("min=" + (a));
// }
// if (a == b)
//     Console.WriteLine("Числа равны !!!");
// else
//     Console.WriteLine("НЕ ДЕЙСТВИТЕЛЬНЫЕ ЗНАЧЕНИЯ");


// Console.WriteLine("Enter two numbers: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number > number2)
// {
//     Console.WriteLine($"Number {number} is greater than {number2}");
// }
// else if (number < number2)
// {
//     Console.WriteLine($"Number {number2} is greater than {number}");
// }
// else if (number == number2)
// {
//     Console.WriteLine("The numbers are equal");
// }
// else
// {
//     Console.WriteLine("Invalid value");
// }


// Console.WriteLine("Enter two numbers: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2)
// {
//     Console.WriteLine("max = " + number1);
//     Console.WriteLine("min = " + number2);
// }
// else if (number1 < number2)
// {
//     Console.WriteLine("max = " + number2);
//     Console.WriteLine("min = " + number1);
// }
// else if (number1 == number2)
// {
//     Console.WriteLine("The numbers are equal");
// }


//Знакомство с языками программирования (семинары)
//Урок 1. Знакомство с языком программирования С#
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

// РОМАНОВ АЮ   НЕ ОТЛАЖЕНА!!!!

// Console.WriteLine("Введите число a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число c");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a == b)
//     if (b == c)
// {
//     Console.WriteLine("Числа равны !!!");
// }
// else 
// if (a > b)
//     if (a > c)
//             Console.WriteLine("max=" + (a));
//     else
// {
//     Console.WriteLine("max=" + (c));
// }
// else if (b > c)
// {
//     Console.WriteLine("max=" + (b));
// }
// else
// {
//     Console.WriteLine("max=" + (c));
// }





// Console.WriteLine("Enter three numbers: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// int number3 = Convert.ToInt32(Console.ReadLine());
// if (number2 > max) max = number2;
// if (number3 > max) max = number3;
// {
//     Console.WriteLine($"The maximum number is {max}");
// }



// Console.WriteLine("Enter three numbers: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// int number3 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2 && number1 > number3)
// {
//     Console.WriteLine($"The maximum number is {number1}");
// }
// else if (number2 > number1 && number2 > number3)
// {
//     Console.WriteLine($"The maximum number is {number2}");
// }
// else
// {
//     Console.WriteLine($"The maximum number is {number3}");
// }


// Знакомство с языками программирования (семинары)
// Урок 1. Знакомство с языком программирования С#

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// РОМАНОВ АЮ

// Console.WriteLine("Введите число ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = 0;
// b = Math.Abs(a % 2);
// if (b > 0)
// {
//     Console.WriteLine("Число нечётное ");
// }
// else
// {
//     Console.WriteLine("Число  чётное ");
// }

// Знакомство с языками программирования (семинары)
// Урок 1. Знакомство с языком программирования С#

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).

//  РОМАНОВ АА

// Console.WriteLine("Enter a number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// if (number1 % 2 == 0)
// {
//     Console.WriteLine($"The number {number1} is even");
// }
// else
// {
//     Console.WriteLine($"The number {number1} is odd");
// }


// Знакомство с языками программирования (семинары)
// Урок 1. Знакомство с языком программирования С#
// Задача 8: Напишите программу, которая на вход принимает число (N > 0),
//  а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// РОМАНОВ АЮ

// Console.WriteLine("Введите число ");
// int N = Convert.ToInt32(Console.ReadLine());
// int a = 2;
// N = Math.Abs(N);
// while (a <= N)
// {
//     Console.Write(a + ",");
//     a = a + 2;
// }
// if (N < 2)
// {
//     Console.WriteLine("Чётных чисел нет!!!");
// }
// Знакомство с языками программирования (семинары)
// Урок 1. Знакомство с языком программирования С#
// Задача 8: Напишите программу, которая на вход принимает число (N > 0),
//  а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// РОМАНОВ АА


// Console.Write("Enter a number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 2;
// while (i <= N)
// {
//     Console.WriteLine(i + " ");
//     i += 2;
// }
// Знакомство с языками программирования (семинары)
// Урок 1. Знакомство с языком программирования С#
// Задача 8: Напишите программу, которая на вход принимает число (N > 0),
//  а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// РОМАНОВ АА

// Console.Write("Enter a number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= N; i++)
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
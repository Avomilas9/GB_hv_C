﻿// Задача 1. Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

//M = 1; N = 5 -> "1,2,3,4,5"
//M = 4; N = 8 -> "4,5,6,7,8"


Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNaturalNumbers(int m, int n)

{
    if (m == 0 || n == 0) return;

    if (m < n)
    {
        Console.Write(m + ", ");
        PrintNaturalNumbers(m + 1, n);
        return;
    }

    else
    {
        if (m > n)
        {
            Console.Write(m + ", ");
            PrintNaturalNumbers(m - 1, n);
            return;
        }
    }

    if (m == n)
    {
        Console.Write(m + ", ");
        return;
    }
}

PrintNaturalNumbers(m, n);
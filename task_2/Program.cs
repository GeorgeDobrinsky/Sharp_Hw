﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Дописать программу если числа равны

System.Console.Write("Введите число а- ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b- ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    System.Console.WriteLine($"Наибольшее число = {a}");
}
else if (a < b)
{
    System.Console.WriteLine($"Наибольшее число = {b}");
}
else
    System.Console.WriteLine($"Числа {a} и {b} равны");
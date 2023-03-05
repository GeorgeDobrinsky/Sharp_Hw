// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Введите число : ");
int x = Convert.ToInt32(Console.ReadLine());
if (x % 2 == 0) 
    System.Console.WriteLine("Число чётное");
else
    System.Console.WriteLine("Число нечётное");
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
System.Console.Write("Введите число x: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число y: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число z: ");
int z = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Максимальное число : ");
Console.Write(Math.Max(x,Math.Max(y,z)));

/* Задача 3: Напишите программу, которая на вход принимает число
и выдаёт, является ли число чётным (делится ли оно на два без остатка). */

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{number % 2 == 0}");
/* Задача 2: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел. */

Console.WriteLine("Введите первое число:");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int third = int.Parse(Console.ReadLine());
int max = first > second ? first : second;
if (max < third)
{
    max = third;
}
Console.WriteLine($"max = {max}");
/* Задача 1: Напишите программу, которая на вход принимает два числа 
и выдаёт, какое число большее, а какое меньшее. */

Console.WriteLine("Введите первое число:");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int second = int.Parse(Console.ReadLine());
if (first > second)
{
    Console.WriteLine($"max = {first}, min = {second}");
}
else
{
    Console.WriteLine($"max = {second}, min = {first}");
}
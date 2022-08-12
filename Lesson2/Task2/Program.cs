/* Задача 2: Напишите программу, которая выводит случайное трёхзначное число
и удаляет вторую цифру этого числа. */

int randomNumber = new Random().Next(100, 1000);
System.Console.WriteLine($"{randomNumber}->{DeleteSecondDigit(randomNumber)}");

int DeleteSecondDigit(int number)
{
    return number / 100 * 10 + number % 10;
}
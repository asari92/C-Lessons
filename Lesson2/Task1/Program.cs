/* Задача 1: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа. */

SecondDigit();

void SecondDigit()
{
    while (true)
    {
        Console.WriteLine("Введите трёхзначное число:");
        bool isParse = int.TryParse(Console.ReadLine(), out int number);
        number = Math.Abs(number);
        if (isParse && number >= 100 && number <= 1000)
        {
            Console.WriteLine(number / 10 % 10);
            break;
        }
        Console.WriteLine("Неверный ввод! Повторите попытку.");
    }
}
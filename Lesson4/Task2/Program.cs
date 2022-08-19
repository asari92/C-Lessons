// // Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

ShowSumOfDigits();

void ShowSumOfDigits()
{
    while (true)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            System.Console.WriteLine($"Сумма цифр = {SumOfDigits(number)}");
            break;
        }
        Console.WriteLine("Неверный ввод! Повторите попытку.");
    }
}

int SumOfDigits(int number)
{
    if (number == 0)
        return 0;
    int result = 0;
    number = Math.Abs(number);
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}
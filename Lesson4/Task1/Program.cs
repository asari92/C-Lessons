// // Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
// // и возводит число A в натуральную степень B.

ShowExponentiation();

void ShowExponentiation()
{
    while (true)
    {
        Console.Write("Введите основание степени: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            while (true)
            {
                Console.Write("Введите показатель степени: ");
                if (int.TryParse(Console.ReadLine(), out int degree))
                {
                    Console.WriteLine($"{number} в степени {degree} = {Exponentiation(number, degree)}");
                    return;
                }
                Console.WriteLine("Неверный ввод! Повторите попытку.");
            }
        }
        Console.WriteLine("Неверный ввод! Повторите попытку.");
    }
}

double Exponentiation(int number, int degree)
{
    if (number == 1)
    {
        return 1;
    }
    if (number == 0)
    {
        return 0;
    }
    double result = 1;
    for (int i = 0; i < Math.Abs(degree); i++)
    {
        result *= number;
    }
    if (degree < 0)
    {
        result = 1 / result;
    }
    return result;
}
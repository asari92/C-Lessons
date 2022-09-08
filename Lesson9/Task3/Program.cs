// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

ShowAccermanFunction(Prompt("Введите число M: "), Prompt("Введите число N: "));

void ShowAccermanFunction(long m, long n)
{
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Оба числа должны быть неотрицательными!");
        return;
    }
    Console.Write("Результат вычисления функции Аккермана для указанных чисел: ");
    Console.WriteLine(CalculateAccermanFunction(m, n));
}

long CalculateAccermanFunction(long m, long n)
{
    if (m < 0 || n < 0)
    {
        return 0;
    }
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m > 0)
    {
        return CalculateAccermanFunction(m - 1, 1);
    }
    return CalculateAccermanFunction(m - 1, CalculateAccermanFunction(m, n - 1));
}

int Prompt(string message)
{
    System.Console.Write(message);
    int number = 0;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Неверный ввод! Повторите попытку.");
        System.Console.Write(message);
    }
    return number;
}
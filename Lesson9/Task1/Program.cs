// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

ShowNaturalEvenRow(Prompt("Введите число M: "), Prompt("Введите число N: "));

void ShowNaturalEvenRow(int m, int n, int i = 0)
{
    if (m > n)
    {
        if (i == 0)
        {
            Console.WriteLine("Число M не должно быть больше числа N!");
        }
        return;
    }
    else if (m == n)
    {
        if (i == 0)
        {
            if (m % 2 != 0)
            {
                Console.WriteLine("Чётные натуральные числа в указанном промежутке отсутствуют!");
                return;
            }
        }
    }

    if (m % 2 == 0)
    {
        Console.Write($"{m} ");
        m += 2;
    }
    else
    {
        m++;
    }
    ShowNaturalEvenRow(m, n, ++i);
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
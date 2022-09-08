// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

ShowNaturalRowSum(Prompt("Введите число M: "), Prompt("Введите число N: "));

void ShowNaturalRowSum(int m, int n)
{
    if (m > n)
    {
        Console.WriteLine("Число M не должно быть больше числа N!");
        return;
    }
    Console.Write("Сумма натуральных элементов в указанном промежутке: ");
    Console.WriteLine(GetNaturalRowSum(m, n));
}

int GetNaturalRowSum(int m, int n)
{
    if (m > n || m < 0 || n < 0)
    {
        return 0;
    }
    if (m == n)
    {
        return m;
    }
    return m + GetNaturalRowSum(m + 1, n);
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
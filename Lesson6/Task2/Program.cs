// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

const string _wrongInput = "Неверный ввод! Повторите попытку.";

ShowIntersectionPoint();

void ShowIntersectionPoint()
{
    Console.WriteLine("y = k1 * x + b1");
    Console.WriteLine("y = k2 * x + b2");
    Console.Write("Введите b1: ");
    GetUserNumber(out int b1);
    Console.Write("Введите k1: ");
    GetUserNumber(out int k1);
    Console.Write("Введите b2: ");
    GetUserNumber(out int b2);
    Console.Write("Введите k2: ");
    GetUserNumber(out int k2);
    int b = b1 - b2;
    int k = k1 - k2;

    if (k == 0)
    {
        if (b == k)
        {
            Console.WriteLine("Прямые совпадают.");
            return;
        }
        Console.WriteLine("Прямые не пересекаются.");
        return;
    }

    double x = (double)-b / k;
    double y = (double)k2 * x + b2;
    Console.WriteLine($"Точка пересечения двух прямых имеет координаты ({x}, {y})");
}

void GetUserNumber(out int number)
{
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine(_wrongInput);
    }
}
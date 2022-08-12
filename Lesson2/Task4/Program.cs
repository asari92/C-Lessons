/* Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным. */

while (true)
{
    Console.WriteLine("Введите цифру, обозначающую день недели(1-7):");
    bool isParse = int.TryParse(Console.ReadLine(), out int dayOfWeek);
    if (isParse && dayOfWeek > 0 && dayOfWeek < 8)
    {
        System.Console.WriteLine(isDayOff(dayOfWeek));
        break;
    }
    Console.WriteLine("Неверный ввод! Повторите попытку.");
}

bool isDayOff(int dayOfWeek)
{
    return (dayOfWeek > 5) ? true : false;
}
/* Задача 3: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет. */

ShowThirdDigit();

void ShowThirdDigit()
{
    Console.WriteLine("Введите число:");
    bool isParse = int.TryParse(Console.ReadLine(), out int number);
    number = Math.Abs(number);
    if (isParse && number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        Console.WriteLine(number % 10);
        return;
    }
    Console.WriteLine("Третьей цифры нет!");
}
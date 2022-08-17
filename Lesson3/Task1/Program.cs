// Задача 1: Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.

ShowIsPalindrom();

void ShowIsPalindrom()
{
    while (true)
    {
        Console.WriteLine("Введите пятизначное число:");
        bool isParse = int.TryParse(Console.ReadLine(), out int number);
        number = Math.Abs(number);
        if (isParse && Digits(number) == 5)
        {
            Console.WriteLine(IsPalindrom(number));
            break;
        }
        Console.WriteLine("Неверный ввод! Повторите попытку.");
    }
}

bool IsPalindrom(int possiblePalindrom)
{
    int length = Digits(possiblePalindrom);
    int[] array = new int[length];
    for (int i = length - 1; i >= 0; i--)
    {
        array[i] = possiblePalindrom % 10;
        possiblePalindrom = possiblePalindrom / 10;
    }
    int j = length - 1;
    for (int i = 0; i < length / 2; i++)
    {
        if (array[i] != array[j])
        {
            return false;
        }
        j--;
    }
    return true;
}

int Digits(int num)
{
    if (num == 0)
        return 1;
    var result = 0;
    while (num > 0)
    {
        num = num / 10;
        result++;
    }
    return result;
}
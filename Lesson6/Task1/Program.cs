// // Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

const string _wrongInput = "Неверный ввод! Повторите попытку.";

ShowGreaterThanZero();

void ShowGreaterThanZero()
{
    int positiveNumbers = 0;

    while (true)
    {
        Console.Write("Укажите сколько чисел вы хотите ввести: ");
        if (int.TryParse(Console.ReadLine(), out int quantity))
        {
            int i = 1;
            while (i <= quantity)
            {
                Console.Write($"Введите {i}е число: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    positiveNumbers += (number > 0) ? 1 : 0;
                    i++;
                    continue;
                }
                Console.WriteLine(_wrongInput);
            }
            break;
        }
        Console.WriteLine(_wrongInput);
    }

    Console.WriteLine($"Вы ввели {positiveNumbers} чис(а/ел) больше 0.");
}
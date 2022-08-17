// Задача 3: Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.

ShowCubes();

void ShowCubes()
{
    while (true)
    {
        Console.Write("Введите число: ");
        bool isParse = int.TryParse(Console.ReadLine(), out int number);
        if (isParse && number > 0)
        {
            Console.WriteLine("{0}", string.Join(", ", getCubes(number)));
            break;
        }
        Console.WriteLine("Неверный ввод! Повторите попытку.");
    }
}

int[] getCubes(int number)
{
    int[] cubes = new int[number];
    for (int i = 0; i < number ; i++)
    {
        cubes[i] = (int) Math.Pow(i + 1, 3);
    }
    return cubes;
}
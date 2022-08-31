// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int m = Prompt("Введите число строк: ");
int n = Prompt("Введите число столбцов: ");
ShowBivariateArray(GetRandomBivariateArray(m, n));

void ShowBivariateArray(double[,] bivariateArray)
{
    int rows = bivariateArray.GetUpperBound(0) + 1;
    int columns = bivariateArray.Length / rows;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{bivariateArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

double[,] GetRandomBivariateArray(int rows, int columns)
{
    double[,] bivariateArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            bivariateArray[i, j] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
        }
    }
    return bivariateArray;
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
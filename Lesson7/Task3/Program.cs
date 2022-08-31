// Задача 3. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int numberOfRows = Prompt("Введите количество строк: ");
int numberOfColumns = Prompt("Введите количество столбцов: ");
int[,] bivariateArray = GetRandomBivariateArray(numberOfRows, numberOfColumns);
ShowBivariateArray(bivariateArray);
System.Console.WriteLine("Среднее арифметическое каждого столбца:");
foreach (var item in GetColumnsAverage(bivariateArray))
{
    Console.Write($"{item}\t");
}

double[] GetColumnsAverage(int[,] bivariateArray)
{
    int rows = bivariateArray.GetLength(0);
    int columns = bivariateArray.GetLength(1);
    double[] averageArray = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        int columnSum = 0;
        for (int i = 0; i < rows; i++)
        {
            columnSum += bivariateArray[i, j];
        }
        averageArray[j] = Math.Round((double)columnSum / rows, 2);
    }
    return averageArray;
}

void ShowBivariateArray(int[,] bivariateArray)
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

int[,] GetRandomBivariateArray(int rows, int columns)
{
    int[,] bivariateArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            bivariateArray[i, j] = new Random().Next(10, 100);
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
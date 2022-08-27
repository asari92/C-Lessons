// Задача 3: Сгенерировать двумерный массив со случайными числами, вывести его на экран, оформить в виде функций.

int[,] bivariateArray = GetRandomBivariateArray(3, 4);
ShowBivariateArray(bivariateArray);

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
// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.

double[] array = GetRandomArray(8);
ShowArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {GetMax(array) - GetMin(array)}");

double GetMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double GetMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

void ShowArray(double[] array)
{
    Console.WriteLine("{0}", string.Join(", ", array));
}

double[] GetRandomArray(int arraySize)
{
    double[] randomArray = new double[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        randomArray[i] = new Random().Next(0, 100);
    }
    return randomArray;
}
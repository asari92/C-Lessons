// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = GetRandomArray(8);
ShowArray(array);
System.Console.WriteLine($"Количество четных чисел = {GetEvenNumbers(array)}");

int GetEvenNumbers(int[] array)
{
    int result = 0;
    foreach (var item in array)
    {
        result += (item % 2 == 0) ? 1 : 0;
    }
    return result;
}

void ShowArray(int[] array)
{
    Console.WriteLine("{0}", string.Join(", ", array));
}

int[] GetRandomArray(int arraySize)
{
    int[] randomArray = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        randomArray[i] = new Random().Next(100, 1000);
    }
    return randomArray;
}
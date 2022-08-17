// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

ShowPointDistance();

void ShowPointDistance()
{
    Console.WriteLine("Введите координаты первой точки: ");
    int[] firstPoint = getPoint(1);
    Console.WriteLine("Введите координаты второй точки: ");
    int[] secondPoint = getPoint(2);

    System.Console.WriteLine($"Расстояние между этими точками равно: {Math.Round(CalculatePointDistance(firstPoint, secondPoint), 2)}");
}

int[] getPoint(int pointNumber)
{
    int[] point = new int[3];
    point[0] = getCoordinate($"x{pointNumber}");
    point[1] = getCoordinate($"y{pointNumber}");
    point[2] = getCoordinate($"z{pointNumber}");
    return point;
}

int getCoordinate(string coordinateAxis)
{
    int coordinate;
    while (true)
    {
        System.Console.Write($"{coordinateAxis}: ");
        bool checkСoordinate = int.TryParse(Console.ReadLine(), out coordinate);
        if (checkСoordinate)
        {
            break;
        }
        Console.WriteLine("Ошибка! Повторите попытку ввода.");
    }
    return coordinate;
}

double CalculatePointDistance(int[] firstPoint, int[] secondPoint)
{
    return Math.Sqrt(Math.Pow(secondPoint[0] - firstPoint[0], 2) +
                    Math.Pow(secondPoint[1] - firstPoint[1], 2) +
                    Math.Pow(secondPoint[2] - firstPoint[2], 2));
}
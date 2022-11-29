// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int DataEntry(string str)
{
    Console.Write(str);
    int number  = int.Parse(Console.ReadLine());
    return number;
}

double PointDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}

Console.Clear();
int x1 = DataEntry("введите координату x1 = ");
int y1 = DataEntry("введите координату y1 = ");
int z1 = DataEntry("введите координату z1 = ");
int x2 = DataEntry("введите координату x2 = ");
int y2 = DataEntry("введите координату y2 = ");
int z2 = DataEntry("введите координату z2 = ");

double result = PointDistance(x1, y1, z1, x2, y2, z2); 
Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {Math.Round(result,2)}");

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    double dist = Math.Sqrt((xc2-xc1)*(xc2-xc1)+(yc2-yc1)*(yc2-yc1)+(zc2-zc1)*(zc2-zc1));
    return dist;
}
Console.WriteLine("Точка А ");
    Console.Write("Введите координату х:");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату y:");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату z:");
    int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Точка B ");
    Console.Write("Введите координату х:");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату y:");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату z:");
    int z2 = Convert.ToInt32(Console.ReadLine());
double result = Distance (x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между ними = {Math.Round(result, 3, MidpointRounding.ToZero)}"); 
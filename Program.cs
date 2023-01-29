// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputInt(string massage)
{
    Console.WriteLine(massage);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
double x1 = InputInt("Введите координаты х первой точки");
double y1 = InputInt("Введите координаты y первой точки");
double z1 = InputInt("Введите координаты z первой точки");
double x2 = InputInt("Введите координаты х второй точки");
double y2 = InputInt("Введите координаты y второй точки");
double z2 = InputInt("Введите координаты z второй точки");

double Dist(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double a;
    double b;
    double c;
    a = x2 - x1;
    b = y2 - y1;
    c = z2 - z1;
    return Math.Sqrt(a * a + b * b + c * c);
}
System.Console.WriteLine($"Расстояние между точками в 3D равно {Dist(x1, x2, y1, y2, z1, z2)}");




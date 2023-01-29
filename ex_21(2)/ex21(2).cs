// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int xa, ya, xb, yb, za, zb;
Console.Write("введите координату X точки A: ");
while(!int.TryParse(Console.ReadLine(), out xa))
{
    Console.Write("Введен неверный параметр, повторите ввод: ");
}
Console.Write("введите координату Y точки A: ");
while(!int.TryParse(Console.ReadLine(), out ya))
{
    Console.Write("Введен неверный параметр: ");
}
Console.Write("введите координату Z точки A: ");
while(!int.TryParse(Console.ReadLine(), out za))
{
    Console.Write("Введен неверный параметр: ");
}
Console.Write("введите координату X точки B: ");
while(!int.TryParse(Console.ReadLine(), out xb))
{
    Console.Write("Введен неверный параметр: ");
}
Console.Write("введите координату Y точки B: ");
while(!int.TryParse(Console.ReadLine(), out yb))
{
    Console.Write("Введен неверный параметр: ");
}
Console.Write("введите координату Z точки B: ");
while(!int.TryParse(Console.ReadLine(), out zb))
{
    Console.Write("Введен неверный параметр: ");
}

double Distance(double xa, double ya, double xb, double yb, double za, double zb)
{
    return Math.Round(Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((za - zb), 2)), 2);
}
double res = Distance(xa, ya, xb, yb, za, zb);
Console.WriteLine($"Расстояние между точками = {res}");
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2 

Console.WriteLine("Введите координаты 2-х точек: A(x1,y1,z1) и B(x2,y2,z2)");
double numX1 = double.Parse(Console.ReadLine());
double numY1 = double.Parse(Console.ReadLine());
double numZ1 = double.Parse(Console.ReadLine());
Console.WriteLine();
double numX2 = double.Parse(Console.ReadLine());
double numY2 = double.Parse(Console.ReadLine());
double numZ2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((numX2-numX1),2) + Math.Pow((numY2-numY1),2) + Math.Pow((numZ2-numZ1),2));
Console.WriteLine($"Расстояние между 2-мя точками в 3D пространстве A({numX1},{numY1},{numZ1}) и B({numX2},{numY2},{numZ2}) = {distance}");

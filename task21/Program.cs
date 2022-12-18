// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

 Console.WriteLine("Введите x точки a: ");
 Console.WriteLine("Введите y точки a: ");
 Console.WriteLine("Введите z точки a: ");
 Console.WriteLine("Введите x точки b: ");
 Console.WriteLine("Введите y точки b: ");
 Console.WriteLine("Введите z точки b: ");

 int xa = int.Parse(Console.ReadLine());
 int ya = int.Parse(Console.ReadLine());
 int za = int.Parse(Console.ReadLine());
 int xb = int.Parse(Console.ReadLine());
 int yb = int.Parse(Console.ReadLine());
 int zb = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2)+Math.Pow((zb-za),2));

Console.WriteLine(result);
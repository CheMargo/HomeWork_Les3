/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*
 _
/(xb-xa)^2 + (yb-ya)^2 + (zb-za)^2*/


System.Console.WriteLine("Введите координату X для точки А: ");
int xA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координату y для точки А: ");
int yA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координату z для точки A: ");
int zA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координату x для точки B: ");
int xB = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координату y для точки B: ");
int yB = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координату z для точки B: ");
int zB = int.Parse(Console.ReadLine());

double resalt = Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));

System.Console.WriteLine(Math.Round(resalt, 3));

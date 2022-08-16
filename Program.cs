//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

using System;
public class Program
{

    public static void Main()
    {
        Console.WriteLine("Введите первую координату точки А x1:  ");
        var x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите вторую координату точки А y1:  ");
        var y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третью координату точки А z1:  ");
        var z1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите первую координату точки B x2:  ");
        var x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите вторую координату точки B y2:  ");
        var y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третью координату точки B z2:  ");
        var z2 = Convert.ToInt32(Console.ReadLine());




        Console.WriteLine((Math.Sqrt((Math.Pow(((x1) - (x2)), 2) + Math.Pow(((y1) - (y2)), 2) + Math.Pow(((z1) - (z2)), 2)))));

    }
}
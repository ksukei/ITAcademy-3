using System;

public class Perimeter
{
    static void Main(string[] args)
    {
        //hi
        Console.Write("Введите длину стороны квадрата (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        double perimeter = 4 * a;

        Console.WriteLine($"Периметр квадрата равен: {perimeter}");
    }
}
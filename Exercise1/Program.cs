
using System;
using Exercise1;
using Exercise1.exception;

public class Program
{
    static IFilter filter = new Filter();
    public static void Main(string[] args)
    {
        Console.WriteLine("===> GeometryExample: ");
        Console.Write("Enter the radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        if (!filter.IsRadiusValid(radius))
        {
            var msg = "Radius is invalid";
            throw new InvalidRadiusException(msg, radius);
        }

        Console.Write("Enter the height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        if (!filter.IsRadiusValid(height))
        {
            var msg = "Height is invalid";
            throw new InvalidRadiusException(msg, height);
        }

        Cylinder cylinder = new Cylinder(radius, height);
        cylinder.Process();

        Console.ReadLine();
    }
}
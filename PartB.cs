using System;

class PartB
{
    static void Main(string[] args)
    {
        double baseLength, height, area;

        Console.WriteLine("This program calculates the area of a triangle.");
        Console.Write("Enter the length of the base: ");
        baseLength = double.Parse(Console.ReadLine());

        Console.Write("Enter the height: ");
        height = double.Parse(Console.ReadLine());

        area = 0.5 * baseLength * height;

        Console.WriteLine("The area of the triangle is: " + area);
    }
}
 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Input the radius of the circle: ");
        double circleRadius = Convert.ToDouble(Console.ReadLine());

        double circleArea = Math.PI * circleRadius * circleRadius;

        Console.WriteLine("The area of the circle is: " + circleArea.ToString("F2"));
    }
}

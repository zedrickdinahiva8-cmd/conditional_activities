using System;

class Program
{
    static void Main()
    {
        const double piValue = 3.14159;

        Console.WriteLine("Choose an option:");
        Console.WriteLine("A - Area");
        Console.WriteLine("P - Perimeter");
        Console.WriteLine("X - Exit");

        Console.Write("Enter your option: ");
        char option = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (option)
        {
            case 'A':

                Console.Write("Enter circle radius: ");
                double circleRadius = Convert.ToDouble(Console.ReadLine());

                double circleArea = piValue * circleRadius * circleRadius;

                Console.WriteLine("Area = " + circleArea);
                break;

            case 'P':

                Console.Write("Enter circle radius: ");
                double radiusValue = Convert.ToDouble(Console.ReadLine());

                double circumference = 2 * piValue * radiusValue;

                Console.WriteLine("Perimeter = " + circumference);
                break;

            case 'X':

                Console.WriteLine("Application Closed.");
                break;

            default:

                Console.WriteLine("Invalid Option.");
                break;
        }
    }
}

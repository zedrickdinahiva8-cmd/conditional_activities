using System;

class Program
{
    static void Main()
    {
        Console.Write("Input your given name: ");
        string givenName = Console.ReadLine();

        Console.Write("Input your family name: ");
        string familyName = Console.ReadLine();

        string completeName = givenName + " " + familyName;

        Console.WriteLine("Complete Name: " + completeName);
    }
}

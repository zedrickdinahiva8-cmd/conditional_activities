using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int value = Convert.ToInt32(Console.ReadLine());

        if (value % 2 == 0)
        {
            Console.WriteLine("The integer " + value + " is even.");
        }
    }
}

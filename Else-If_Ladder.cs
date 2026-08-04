using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter person's age: ");
        int personAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter monthly salary: ");
        double monthlySalary = Convert.ToDouble(Console.ReadLine());

        if (personAge >= 25 && personAge <= 35 && monthlySalary > 50000)
        {
            Console.WriteLine("Young Professional");
        }
        else if (personAge >= 36 && personAge <= 55 && monthlySalary > 70000)
        {
            Console.WriteLine("Middle-Aged Professional");
        }
        else if (personAge >= 56 && monthlySalary < 30000)
        {
            Console.WriteLine("Senior Citizen");
        }
        else
        {
            Console.WriteLine("Other");
        }
    }
}

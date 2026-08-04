using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter deposited amount: ");
        double depositAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual interest rate (%): ");
        double interestRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter investment period (years): ");
        double investmentYears = Convert.ToDouble(Console.ReadLine());

        double totalInterest = (depositAmount * interestRate * investmentYears) / 100;

        Console.WriteLine("Computed Simple Interest: " + totalInterest);
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter exam score: ");
        int examScore = Convert.ToInt32(Console.ReadLine());

        string status = (examScore >= 50) ? "Passed" : "Failed";

        Console.WriteLine(status);
    }
}

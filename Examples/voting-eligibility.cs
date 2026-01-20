using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
            Console.WriteLine("Eligible for Voting");
        else
            Console.WriteLine("Not Eligible for Voting");
    }
}

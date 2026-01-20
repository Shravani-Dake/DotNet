using System;

class Program
{
    static void Main()
    {
        int num = 7;
        int count = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
                count++;
        }

        if (count == 2)
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Not a Prime Number");
    }
}

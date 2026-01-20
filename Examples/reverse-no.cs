using System;

class Program
{
    static void Main()
    {
        int num = 1234;
        int rev = 0;

        while (num > 0)
        {
            rev = rev * 10 + (num % 10);
            num = num / 10;
        }

        Console.WriteLine("Reverse = " + rev);
    }
}

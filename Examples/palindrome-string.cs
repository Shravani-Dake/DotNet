using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        char[] arr = str.ToCharArray();
        Array.Reverse(arr);

        string rev = new string(arr);

        if (str.Equals(rev))
            Console.WriteLine("Palindrome String");
        else
            Console.WriteLine("Not a Palindrome String");
    }
}

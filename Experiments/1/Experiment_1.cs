class Arithmetic 
{
    public static void Main()
    {
        int num1 = 10;
         int num2 = 20;

        int add = num1 + num2;
        int sub = num1 - num2;
        int mul = num1 * num2;
        int div = num1 / num2;
        int mod = num1 % num2;
        num1++;
        num2--;

        System.Console.WriteLine("Addition : " + add);
        System.Console.WriteLine("subtraction : " + sub);
        System.Console.WriteLine("multiplication : " + mul);
        System.Console.WriteLine("division : " + div);
        System.Console.WriteLine("modulus : " + mod);
        System.Console.WriteLine(num1);
        System.Console.WriteLine(num2);
    }
}
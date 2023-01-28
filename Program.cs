using System;
// See https://aka.ms/new-console-template for more information

public class Lab6
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.Write("How many numbers do you want to find the power of (2 or 3): ");
        int z = (int)Convert.ToDecimal(Console.ReadLine());
        if (z == 2)
        {
            Console.Write("Enter a number for a: ");
            int a = (int)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter a number for a: ");
            int b = (int)Convert.ToDecimal(Console.ReadLine());
            double d = Math.Pow(a, b);
            Console.WriteLine("{0} to the power of {1} is {2}", a, b, d);
        }
        else
        {
            Console.Write("Enter a number for a: ");
            int a = (int)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter a number for a: ");
            int b = (int)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter a number for a: ");
            int c = (int)Convert.ToDecimal(Console.ReadLine());
            double d = Math.Pow(a, b);
            double e = Math.Pow(d, c);
            Console.WriteLine("{0} to the power of {1} to the power of {2} is {3}", a, b, c, e);
        }
    }
    public Lab6()
    {
    }
}

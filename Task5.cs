using System;

public class Class1
{
	public Class1()
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
            double d = powerNumber(a, b);
            Console.WriteLine("{0} to the power of {1} is {2}", a, b, d);
        }
        else
        {
            Console.Write("Enter a number for a: ");
            int a = (int)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter a number for b: ");
            int b = (int)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter a number for c: ");
            int c = (int)Convert.ToDecimal(Console.ReadLine());
            double d = powerNumber(a, b);
            double e = powerNumber(d, c);
            Console.WriteLine("{0} to the power of {1} to the power of {2} is {3}", a, b, c, e);
        }
    }
}
	public static double powerNumber(int num1, int num2)
	{
		int a = Math.Pow(num1, num2);
	}
}

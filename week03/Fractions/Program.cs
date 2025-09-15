using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        Console.WriteLine(f1.getFractionString());
        Console.WriteLine(f2.getFractionString());
        Console.WriteLine(f3.getFractionString());

        Console.WriteLine(f3.getDecimalValue());

        f3.setTop(3);
        f3.setBottom(4);
        Console.WriteLine(f3.getFractionString());
        Console.WriteLine(f3.getDecimalValue());

    }

    
}
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in ett tal");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Skriv in ett tal");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(" talet "+a+" upphöjt med "+b+" = "+ potens(a,b));
    }
    static double potens(double a, double b)
    {
        double p = a;
        for (double i = 1; i <b;i++)
        {
            p *= a;
        }
        return p;
    }
}

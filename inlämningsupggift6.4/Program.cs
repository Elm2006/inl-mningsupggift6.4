using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in ett tal");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Skriv in ett tal");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(" talet "+a+" upphöjt med "+b+" = "+ potens(a,b));
    }
    static int potens(int a, int b)
    {
        int p = a;
        for (int i = 1; i <b;i++)
        {
            p *= a;
        }
        return p;
    }
}

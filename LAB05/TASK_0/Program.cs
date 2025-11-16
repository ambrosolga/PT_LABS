using System;

namespace OOP_RATIONAL
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Rational r1 = new Rational(4, 8);
            Rational r2 = new Rational(2, -5);
            Rational r3 = new Rational(-3, -4);

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);

            Console.WriteLine($"r1 == r2: {r1 == r2}"); 
            Console.WriteLine($"r1 != r2: {r1 != r2}"); 
            Console.WriteLine($"r1 > r2: {r1 > r2}");   
            Console.WriteLine($"r1 < r2: {r1 < r2}");   
            Console.WriteLine($"r1 >= r2: {r1 >= r2}"); 
            Console.WriteLine($"r1 <= r2: {r1 <= r2}"); 
            Console.WriteLine($"r2 == r3: {r2 == r3}"); 
            Console.WriteLine($"r2 < r3: {r2 < r3}");   
            Console.WriteLine($"r2 <= r3: {r2 <= r3}");
        }
    }
}
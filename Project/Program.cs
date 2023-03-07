using System;
using Library;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Automatikusan kiir mindent, ");
            System.Console.WriteLine("plussz, minusz, szorzas, osztas");

            int x = 20;
            int y = 5;

            int osszeadas = Class1.Add(x, y);
            int kivonas = Class1.Minus(x, y);
            int szorzass = Class1.Subb(x, y);
            int osztass = Class1.Per(x, y);

            System.Console.WriteLine("Az ertekek: {0}, {1}, {2}, {3}", osszeadas, kivonas, szorzass, osztass);
        }
    }
}

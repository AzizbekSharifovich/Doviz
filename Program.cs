using System;

namespace  Doviz
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Usd to Uzs");
            Console.WriteLine("How much do you have");
            decimal Usd = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Converting from Usd to Uzs...");
            const decimal Uzs = 11600;
            Console.WriteLine($"{Usd} * {Uzs} = {Usd * Uzs}");
        }
    }
}
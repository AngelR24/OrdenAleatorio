using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomOrder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Inserte un número N para imprimir números aleatorios.");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("El número debe ser mayor que 0");
                Console.WriteLine("Intente otra vez:");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("**************************************");
            printRandomNumbers(n);
            Console.WriteLine("**************************************");
            Console.WriteLine("Completado.");
            Console.ReadKey();
        }

        private static void printRandomNumbers(int n)
        {
            var numbers = Enumerable.Range(1, n);
            Random r = new Random();
            var randomNumbers = numbers.OrderBy(x => r.Next()).Take(n);
            foreach (var number in randomNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

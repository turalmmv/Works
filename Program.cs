using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, i, show = 0;
            Console.WriteLine("Enter number: ");
            string input = Console.ReadLine();
            int n = int.Parse(input);
            Console.WriteLine("Fibonacci numbers' count: " + n);

            for (i = 0; i < n; i++)
            {
                show = a + b;
                a = b;
                b = show;
                Console.WriteLine(show);
            }

        }
    }
}

using System;

namespace CG_6_2_Upper_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in your favorite quote.  ");
            string quote = Console.ReadLine();

            
            Console.WriteLine(quote.ToUpper());

            Console.ReadLine();
        }
    }
}

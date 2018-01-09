using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReview
{
    class Program
    {
        Salutation salutate = new Salutation("hello","goodbyey");
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            // salutation for a walmart greeter.
            Salutation oldGuy = new Salutation("Welcome to Walmart!", "Thanks for shopping at Walmart!");
            Console.WriteLine(oldGuy.Greet());
            Console.WriteLine(oldGuy.Farewell());

            Console.ReadKey();
        }
    }
}

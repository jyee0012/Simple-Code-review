using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Program();
            app.Run();
            
            Console.Write("Press any key to continue.....");
            Console.ReadKey();
        }

        // Our "Program" is really the "heart" of our "application"
        // So, Let's treat it like an object.
        // We'll use a property that holds a bunch of Salutation objects.
        
        public List<Salutation> Speakers { get; private set; }
        public Program()
        {
            // The job of a constructor is to make sure that all the properties/fields of the object are set to "meaningful values"
            Speakers = new List<Salutation>();
            Speakers.Add(new Salutation("Welcome to Walmart!", "Thanks for shopping at Walmart!","oldGuy"));
            Speakers.Add(new Salutation("nuqneH!", "Qapla'!", "klingonCommander"));
        }
        void Run()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("You have entered a large building. {0} beings stand before you.", Speakers.Count);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Who do you want to speak to? ");
            foreach (Salutation person in Speakers)
            {
                Console.Write(person.name);
                if (person != Speakers[Speakers.Count-1])
                {
                    Console.Write(" or ");
                }
                else
                {
                    Console.Write("?");
                }
            }
            string input = "C";
            while (input != "A" && input != "B")
            {
                input = Console.ReadLine().ToUpper();
            }
            Console.ResetColor();
            switch(input)
            {
                case "A":
                    GreetAndFarewell(Speakers[0]);
                    break;
                case "B":
                    GreetAndFarewell(Speakers[1]);
                    break;
                default:
                    break;
            }
        }
        void GreetAndFarewell(Salutation person)
        {
            Console.WriteLine(person.Greet());
            Console.WriteLine(person.Farewell());

            Console.WriteLine();
        }
    }
}

using System;
using CollectionFunction;
using HouseFunction;
//This is a comment 

/*
will be a comment
we use PascelCase for the most part and that means naimg artifacts as EverythingWillBeCapitalized
*/

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program.Example();

            House Christian = new House();
            //Console.WriteLine(Christian.owner);
            Christian.MiceName = "Jerry";
            Christian.Owner = "Colin";
            Console.WriteLine(Christian.MiceName);
            Console.WriteLine(Christian.Owner);
            Console.WriteLine(Christian.Owner);

            //Solution to group activity to record a user input from the terminal
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine(); // Readline method is the same as the read CLI from the bash scripting 

            Console.WriteLine($"Hello {name}! Welcome to programming!"); // This is a example of string interpolation in C#

            Collection collectionObj = new Collection();
            collectionObj.CollectionMain();
        }

        public static int Example ()
        {

            return 10;

        }

        static void main(string[]args)
        {
            Console.WriteLine("Hello World"!);
        }
    }
}

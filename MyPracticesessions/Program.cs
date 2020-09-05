using System;

namespace MyPracticesessions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

            string characterName = "Tom";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was "+ characterAge +" years old");

            characterName = "Mike";

            Console.WriteLine("He loved the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadLine();
        }
    }
}

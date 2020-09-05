using System;

namespace MyPracticesessions
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Tom";
            int characterAge;
            characterAge = 25;
            string phrase = "Girrafe Academy " + "is cool";
            char grade = 'A';
            int age = 30;
            double gpa = 3.2;
            bool isMale = true;

            Console.WriteLine("Hello World");

            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was "+ characterAge +" years old");

            characterName = "Mike";

            Console.WriteLine("He loved the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.WriteLine("Giraffe\nAcademy");

            Console.WriteLine(phrase);

            Console.WriteLine(phrase.Length);

            Console.WriteLine(phrase.ToUpper());

            Console.ReadLine();
        }
    }
}

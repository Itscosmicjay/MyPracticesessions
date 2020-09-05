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
            int num = 10;
            num--;

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

            Console.WriteLine(phrase.ToLower());

            Console.WriteLine(phrase.Contains("Academy"));

            Console.WriteLine(phrase.Contains("Academies"));

            Console.WriteLine(phrase[0]);

            Console.WriteLine(phrase.IndexOf("Academy"));

            Console.WriteLine(phrase.IndexOf('f'));

            Console.WriteLine(phrase.IndexOf('z'));

            Console.WriteLine(phrase.Substring(8));

            Console.WriteLine(phrase.Substring(8, 3));

            Console.WriteLine(4+2*3);

            Console.WriteLine((4 + 2) * 3);

            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}

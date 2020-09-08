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
            int num = 10;
            num--;
            int num1 = Convert.ToInt32("45");

            Console.WriteLine("Hello World");

            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

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

            Console.WriteLine(4 + 2 * 3);

            Console.WriteLine((4 + 2) * 3);

            Console.WriteLine(num);

            Console.WriteLine(Math.Sqrt(9));

            Console.WriteLine(Math.Max(4, 40));

            Console.WriteLine(Math.Min(5, 10));

            Console.WriteLine(Math.Round(10.6));

            Console.Write("Enter your name: ");

            string name = Console.ReadLine();

            Console.Write("Enter your age: ");

            string age = Console.ReadLine();

            Console.WriteLine("Hello " + name + " you are " + age);

            Console.WriteLine(num1 + 6);

            Console.Write("Enter a number: ");

            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");

            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num2+num3);

            string color, pluralNoun, celebrity;

            Console.Write("Enter a color:");
            color = Console.ReadLine();

            Console.Write("Enter a pluralNoun:");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity:");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);

            Console.WriteLine(pluralNoun + " are blue");

            Console.WriteLine("I love " + celebrity);

            int [] luckyNumbers = { 4, 8, 15, 16, 23, 42};
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Henry";
            friends[2] = "Shem";
            friends[3] = "Han";
            friends[4] = "Smith";

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]);

            Console.ReadLine();
        }
    }
    static void SayHi()
    {
        Console.WriteLine("Hello user");
    }
}

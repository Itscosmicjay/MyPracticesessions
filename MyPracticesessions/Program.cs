﻿using System;

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

            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");

            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num2+num3);



            Console.ReadLine();
        }
    }
}

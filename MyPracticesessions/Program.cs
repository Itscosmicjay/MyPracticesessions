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

            SayHi("Mike", 23);
            SayHi("John", 21);
            SayHi("Tom", 56);

            Console.WriteLine(cube(5));

            bool isMale = true;
            bool isTall = true;
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall) {
                Console.WriteLine("You are not a male but you are tall");
            }else
            {
                Console.WriteLine("You are not male and not tall");
            }
            Console.WriteLine(Getmax(2,10));

            Console.WriteLine(Getmax1(2, 10, 8));

            Console.Write("Enter a number:");
            double digit1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator:");
            string op = Console.ReadLine();

            Console.Write("Enter another number:");
            double digit2 = Convert.ToDouble(Console.ReadLine());

            if(op=="+")
            {
                Console.WriteLine(digit1 + digit2);
            }else if (op=="-")
            {
                Console.WriteLine(digit1 - digit2);
            }
            else if (op == "*")
            {
                Console.WriteLine(digit1 * digit2);
            }
            else if (op == "/")
            {
                Console.WriteLine(digit1 / digit2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.WriteLine(GetDay(0));

            int index = 1;
            while (index<=5)
            {
                Console.WriteLine(index);
                index++;
            }
            int index1 = 6;
            do
            {
                Console.WriteLine(index1);
                index++;
            } while (index1 <= 5);

            string secretWord = "girrafe";
            string guess = "";
            while (guess != secretWord)
            {
                Console.Write("Enter guess:");
                guess = Console.ReadLine();
            }
            Console.WriteLine("You Win!");
            Console.ReadLine();
        }
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
        static int Getmax(int num1, int num2)
        {
            int result;
            if (num1>num2)
            {
                result = num1;
            }
            else {
                result = num2;
            }
            return result;
        }
        static int Getmax1(int num1, int num2, int num3)
        {
            int result;
            if (num1>=num2 && num1>=num3)
            {
                result = num1;
            }
            else  if(num2>=num1 && num2>=num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;

        }
        static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;

                default:
                    dayName = "Invalid day Number";
                    break;
            }
            return dayName;
        }

    }
  
}

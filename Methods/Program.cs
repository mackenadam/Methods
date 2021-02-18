using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Void return value methods
            WriteSomething();
            WriteSomethingSpecific("I am an argument, called from a method.");

            // Non void return value methods
            Console.WriteLine(Add(15, 32));
            // Methodception
            int result = Add(Add(1, 2), Add(3, 4));
            Console.WriteLine(result);
            Console.WriteLine(Multiply(result, 9));
            Console.WriteLine(Divide(1, 3));

            // Challenge
            string friend1 = "Khalid";
            string friend2 = "Johnny";
            string friend3 = "Julien";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);

            // Getting input
            Console.WriteLine("Please enter a number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Please enter a second number to be added to the first:");
            string input2 = Console.ReadLine();
            Console.WriteLine(Add(Int32.Parse(input1), Int32.Parse(input2)));
            

        }

        // Syntax
        // <Access modifier> (Static) <Return value> <Name> (Paramaters (<Data type> <Name>))
        // i.e
        public static void WriteSomething()
        {
            Console.WriteLine("Called from method.");
        }

        public static void WriteSomethingSpecific(string specificText)
        {
            Console.WriteLine(specificText);
        }

        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }

        // Challenge
        public static void GreetFriend(string name)
        {
            Console.WriteLine("Hello " + name + ", my friend.");
        }

    }
}

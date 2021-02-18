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
    }
}

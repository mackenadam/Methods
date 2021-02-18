using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument, called from a method.");
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
    }
}

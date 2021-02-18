using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
        }

        // Syntax
        // <Access modifier> (Static) <Return value> <Name> (Paramaters (<Data type> <Name>))
        // i.e
        public static void WriteSomething()
        {
            Console.WriteLine("Called from method.");
            Console.Read();
        }
    }
}

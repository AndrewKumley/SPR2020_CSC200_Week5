using System;

namespace Week5ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SayGoodbye();
            SayHelloTo("name");
            SayGoodbyeTo("name");

            int a = 237;
            int b = 583;
            int sum = Sum(a, b);
            Console.WriteLine("The sum of " + a + " and " + b + " is " + sum + ".");
            Console.WriteLine(CountSpaces("This is a test."));
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye");
        }

        public static void SayHelloTo(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public static void SayGoodbyeTo(string name)
        {
            Console.WriteLine("Goodbye " + name);
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int CountSpaces(string str)
        {
            int spaces = 0;
            for(int i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Equals(" ")) spaces++;
            }

            return spaces;
        }
    }
}

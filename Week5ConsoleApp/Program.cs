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
    }
}

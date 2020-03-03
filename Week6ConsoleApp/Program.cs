using System;

namespace Week6ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            Foo(ref a);
            Console.WriteLine(a + "\n");

            MyValue myValue = new MyValue();
            myValue.A = 25;
            Foo(myValue);
            Console.WriteLine(myValue.A + "\n");

            int b = 553;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}\n", a, b);
        }

        static void Foo(MyValue myValue)
        {
            myValue.A = myValue.A * 25;
        }

        static void Foo(ref int a)
        {
            a = a * 25;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }



        internal class MyValue
        {
            public int A { get; set; }
        }
    }
}

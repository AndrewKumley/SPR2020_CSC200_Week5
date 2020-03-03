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

            Zero(out a);
            Console.WriteLine("a = {0}\n", a);

            int month, day, year;
            Extract(DateTime.Today, out month, out day, out year);
            Console.WriteLine("{0}/{1}/{2}\n", month, day, year);

            string phrase = "This is a simple test.";
            int c, num, vowels, cons;
            GetCharacterCount(phrase, out c, out num, out vowels, out cons);
            Console.WriteLine("The phrase '{0}' has {1} characters, {2} numbers, {3} vowels, and {4} consonants.", phrase, c, num, vowels, cons);
        }

        static void Zero(out int a)
        {
            a = 0;
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

        static void Extract(System.DateTime today, out int month, out int day, out int year)
        {
            month = today.Month;
            day = today.Day;
            year = today.Year;
        }

        static void GetCharacterCount(string phrase, out int c, out int num, out int vowels, out int cons)
        {
            phrase = phrase.ToLower();
            c = 0;
            num = 0;
            vowels = 0;
            cons = 0;
            foreach(char ch in phrase)
            {
                c += 1;
                if (Char.IsDigit(ch)) num += 1;
                else if ("aeiou".IndexOf(ch) >= 0) vowels += 1;
                else if ("bcdfghjklmnpqrstvwxyz".IndexOf(ch) >= 0) cons += 1;
            }
        }

        internal class MyValue
        {
            public int A { get; set; }
        }
    }
}

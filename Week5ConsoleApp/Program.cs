using System;
using System.Collections.Generic;

namespace Week5ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SayGoodbye();
            SayHelloTo("name");
            SayGoodbyeTo("name\n");

            int a = 237;
            int b = 583;
            int sum = Sum(a, b);
            Console.WriteLine("The sum of " + a + " and " + b + " is " + sum + ".\n");

            int iTest = CountSpaces("This contains 3 spaces.");
            Console.WriteLine(iTest + "\n");

            a = 3;
            b = 12;
            int product = Product(a, b);
            Console.WriteLine("The product of " + a + " and " + b + " is " + product + ".\n");

            a = 6;
            int factorial = Factorial(a);
            Console.WriteLine("{0} factorial is {1}.\n", a, factorial);

            string sTest = ReplaceLetter("This is a test.", 's', 'b');
            Console.WriteLine(sTest + "\n");

            string parallelogram = MakeAsciiParallelogram('l', 2, 3);
            Console.WriteLine(parallelogram + "\n");

            string rect = MakeAsciiRect(']', 5, 9);
            Console.WriteLine(rect + "\n");

            int[] array = new int[] { 3, 6, 1, 8, 9 };
            string sArray = String.Join(", ", new List<int>(array).ConvertAll(i => i.ToString()).ToArray());
            int sumOfArray = SumOfArray(array);
            Console.WriteLine("The sum of all the numbers in the array [{0}] is {1}.\n", sArray, sumOfArray);

            int max = MaxInArray(array);
            Console.WriteLine("The largest number in the array [{0}] is {1}.\n", sArray, max);

            int min = MinInArray(array);
            Console.WriteLine("The smallest number in the array [{0}] is {1}.\n", sArray, min);
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
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i, 1).Equals(" ")) spaces++;
            }

            return spaces;
        }

        public static int Product(int a, int b)
        {
            return a * b;
        }

        public static int Factorial(int n)
        {
            int factorial = 1;
            while (n > 1)
            {
                factorial *= n;
                n--;
            }
            return factorial;
        }

        public static string ReplaceLetter(string str, char c1, char c2)
        {
            string modifiedStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                char temp = str[i];
                if (temp.Equals(c1)) modifiedStr += c2;
                else modifiedStr += temp;
            }

            return modifiedStr;
        }

        public static string MakeAsciiParallelogram(char c, int h, int w)
        {
            string parallelogram = "";
            int spaces = 0;

            for (int row = 0; row < h; row++)
            {
                for (int col = 0; col < w; col++)
                {
                    parallelogram += c;
                }
                parallelogram += "\n";
                spaces++;
                for (int blank = 0; blank < spaces; blank++)
                {
                    parallelogram += " ";
                }
            }


            return parallelogram;
        }

        public static string MakeAsciiRect(char c, int h, int w)
        {
            string rect = "";

            for (int row = 0; row < h; row++)
            {
                for (int col = 0; col < w; col++)
                {
                    rect += c;
                }
                rect += "\n";
            }

            return rect;
        }

        public static int SumOfArray(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }

            return sum;
        }

        public static int MaxInArray(int[] array)
        {
            int max = array[0];

            foreach (int i in array)
            {
                if (i > max) max = i;
            }
            return max;
        }

        public static int MinInArray(int[] array)
        {
            int min = array[0];

            foreach (int i in array)
            {
                if (i < min) min = i;
            }
            return min;
        }
    }
}

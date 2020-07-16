using System;

namespace ConsoleApp1
{
    class Program
    {
        private int count;
        public int Count
        {
            get { return count; }
            set { count = 42; } // 3237 - Noncompliant
        }

        public void doSomething(int param1, int param2, int param3, string param4, long param5, long param6, long param7, long param8)
        {
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Console.WriteLine("Hello World!aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");

        }

        public class Rectangle
        {
            private readonly int length;
            private readonly int width;  // 4487 width is written but never read

            public Rectangle(int length, int width)
            {
                this.length = length;
                this.width = width;
            }

            public int Surface
            {
                get
                {
                    return length * length;
                }
            }
        }
    }
}

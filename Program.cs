using System;

namespace CaBug
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Foo
    {
        public int[] Numbers { get; set; } = new int[] { 1, 2, 3 };
    }
}


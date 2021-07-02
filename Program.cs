using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("print");

            string print = "print2";
            Console.WriteLine(print);

            print = "print3";
            Console.WriteLine(print);

            Console.WriteLine("hello " + print);
        }
    }
}

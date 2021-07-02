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

            Console.WriteLine($"hello {print}");

            Console.WriteLine($"{print}, {print.Length}");

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");
        }
    }
}

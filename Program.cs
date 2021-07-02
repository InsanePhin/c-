using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            //output
            Console.WriteLine("print");
            
            //set string
            string print = "print2";
            Console.WriteLine(print);
            
            //update(edit) string content and print
            print = "print3";
            Console.WriteLine(print);

            //output string add
            Console.WriteLine("hello " + print);

            //it like python f-string
            Console.WriteLine($"hello {print}");

            //string length(len)
            Console.WriteLine($"{print}, {print.Length}");

            //set empty content
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            //start empty remove
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            //end empty remove
            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            //all empty remove
            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            //set hello
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            //replace content
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            //all content upper and lower
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());      
        }
    }
}

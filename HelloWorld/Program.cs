using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //this is a commentary
            //Console.WriteLine("Hello, Julia!");
            /* 1. The program ask the user's name
             * 2. The user enters their name
             * 3. The program greets the user by their name*/
            Console.WriteLine("What's your name?");
            string Name;
            //read the input from the user
            Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);

        }
    }
}

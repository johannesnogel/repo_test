using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite football player t-shirt number");
            string number = Console.ReadLine();
            int numberParsed = Int16.Parse(number);

            // Teen siia if ja else loogikaga vastused
            // nt kui on alla 50, siis tuleb console writeline vastus

            if (numberParsed <= 20)

                Console.WriteLine("Enter your favorite football players name");
            string name = Console.ReadLine();
            int nameParsed = Int16.Parse(name);

            // 

                       
            
        }
    }
}

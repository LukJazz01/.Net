using System;

namespace Sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = null;

            Console.WriteLine("Insert a number");
            x = Console.ReadLine();

            if (Char.IsLetter((char)x[0]))
            {
                Console.WriteLine("INSERT A NUMBER");
            }

            if (Char.IsNumber((char)x[0]))
            {   

                Console.WriteLine("Insert " +x +" numbers");
            }

            Console.ReadLine();
        }
    }
}

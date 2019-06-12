using System;

namespace Ejercicios_Basicos
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry = null;
            int i = 0;

            Console.WriteLine("Enter a number");
            entry = Console.ReadLine();
            int number = int.Parse(entry);

            if (i != number)
            {
                while (number > i){
                    Console.WriteLine("Enter another number");
                    Console.ReadLine();
                    i++;
                }
            }
        }
    }
}

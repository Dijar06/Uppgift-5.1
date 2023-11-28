using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            for (int i = 0; i<namn.GetLength(0); i++)
            {
                Console.WriteLine("Skriv in namn " + (i + 1) + ":");
                namn[i] = Console.ReadLine();
            }
            for (int i = 0; i<namn.GetLength(0); i++)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}
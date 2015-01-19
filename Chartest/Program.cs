using System;
using System.Text;

class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            char symbol = (char)169;

            Console.WriteLine("    "+symbol);
            Console.WriteLine("  " + symbol+ "   " +symbol);
        }
    }


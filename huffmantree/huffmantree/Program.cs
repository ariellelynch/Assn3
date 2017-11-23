using System;
using System.Collections.Generic;

namespace huffmantree
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to be encoded: ");
            var inputString = Console.ReadLine();
            Encoder newEncoder = new Encoder(inputString);
            Console.Write("Encoded string: ");
            Console.WriteLine(newEncoder.Encode());
        }
    }
}

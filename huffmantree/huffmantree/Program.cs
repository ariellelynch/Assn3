using System;
using System.Collections.Generic;

namespace huffmantree
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string to be encoded: ");
            var inputString = Console.ReadLine();
            Encoder newEncoder = new Encoder(inputString);
            Console.Write("Encoded string: ");
            Console.WriteLine(newEncoder.Encode());
            Console.Write("The decoded text was: ");
            Console.WriteLine(newEncoder.Decode());
        }
    }
}


using System;
using System.Linq;

namespace DeveloperTest
    {
    class Program
        {
        static void Main (string[] args)
            {
            if (args.Length != 1)
                {
                Console.WriteLine ("Usage: dotnet DeveloperTest.dll \"Test string to do calculations with\"");
                return;
                }

            // Using first argument as input string.
            StringHelper.CountWords (args[0], out var wordCountDictionary, out var wordLengthContDictionary);


            // Print outputs
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Setting console to print unicode.

            Console.WriteLine ($"List: {string.Join(", ", wordCountDictionary.Select (kvp => $"\"{kvp.Key}, {kvp.Value}\""))}");
            Console.WriteLine ($"List: {string.Join(", ", wordLengthContDictionary.Select (kvp => $"\"{kvp.Key}, {kvp.Value}\""))}");
            Console.WriteLine ("Press Enter to continue...");
            Console.ReadLine ();
            }
        }
    }

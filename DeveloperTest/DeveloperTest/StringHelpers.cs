using System;
using System.Collections.Generic;
using System.Linq;

namespace DeveloperTest
    {
    public static class StringHelper
        {
        public static void CountWords (string input, out Dictionary<string, int> wordCountDictionary, out SortedDictionary<int, int> wordLengthCountDictionary)
            {
            // Could not use whitespace as separators because text might include punctuation.
            string[] separators = { ",", ".", "!", "?", ";", ":", "/", "\\", "\'", "\"", "(", ")", "[", "]", "<", ">", " ", "\t", "\r", "\n" };
            var words = input.Split (separators, StringSplitOptions.RemoveEmptyEntries);

            wordCountDictionary = words.GroupBy (word => word).ToDictionary (w => w.Key, w => w.Count ());

            // Using SortedDictionary so the results would be sorted for readability.
            wordLengthCountDictionary = new SortedDictionary<int, int> (words.GroupBy (word => word.Length).ToDictionary (w => w.Key, w => w.Count ()));
            }

        // Function for 2nd task
        public static string foo (string argument)
            {
            // Function performs string reversal.
            // Removed call stack limitations.
            // Using reverse iterator to create new string.
            return new string (argument.Reverse ().ToArray ());
            }

        }
    }
